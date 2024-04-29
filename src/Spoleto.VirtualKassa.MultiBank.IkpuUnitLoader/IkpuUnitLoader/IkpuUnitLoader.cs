using System.Data;
using System.Data.Common;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.WpfTester.IkpuUnitLoader
{
    internal class IkpuUnitLoader
    {
        private const int BulkInsertTimeout = 300;
        private const int BulkInsertBatchSize = 10000;

        private readonly IkpuUnitLoaderOptions _options;
        private readonly HttpClient _httpClient;

        private record IdCode(Guid Id, string Code);

        public IkpuUnitLoader(IkpuUnitLoaderOptions options, HttpClient httpClient)
        {
            ArgumentNullException.ThrowIfNull(options);
            ArgumentNullException.ThrowIfNull(httpClient);

            _options = options;

            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _options.BearerToken);
            _httpClient.Timeout = TimeSpan.FromMinutes(60);
        }

        public async Task LoadIkpuUnitsAsync(CancellationToken cancellationToken = default)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = _options.MaxDegreeOfParallelism };
            var ikpuIdCodes = GetIkpuIdCodesAsync(cancellationToken);

            var unitsToInsert = new List<(IdCode idCode, IkpuResponse ikpuResponse)>();
            var semaphore = new SemaphoreSlim(1, 1);

            await Parallel.ForEachAsync(ikpuIdCodes, options, async (ikpuIdCode, token) =>
            {
                Console.WriteLine($"Loading data for {ikpuIdCode.Code}...");

                try
                {
                    var ikpuResponse = await LoadIkpuUnitAsync(ikpuIdCode, cancellationToken).ConfigureAwait(false);
                    if (ikpuResponse?.Data.Count > 0)
                    {
                        await semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                        try
                        {
                            unitsToInsert.Add((ikpuIdCode, ikpuResponse));

                            if (unitsToInsert.Count >= 100)
                            {
                                // Write data into the database
                                await SaveIkpuUnitAsync(unitsToInsert, cancellationToken).ConfigureAwait(false);
                                unitsToInsert.Clear();
                            }
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 
                }
            });

            if (unitsToInsert.Count > 0)
            {
                // Write data into the database
                await SaveIkpuUnitAsync(unitsToInsert, cancellationToken).ConfigureAwait(false);
                unitsToInsert.Clear();
            }

            unitsToInsert = null;
        }

        private async IAsyncEnumerable<IdCode> GetIkpuIdCodesAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            using var connection = new SqlConnection(_options.ConnectrionString);
            await connection.OpenAsync(cancellationToken).ConfigureAwait(false);

            var sql = $@"SELECT parent.{_options.IdColumnName}, parent.{_options.CodeColumnName} FROM {_options.OriginIkpuTableName} parent
LEFT JOIN {_options.TargetIkpuUnitTableName} unit ON unit._id_classifier_code = parent.{_options.IdColumnName}
WHERE 
NOT EXISTS (
    SELECT child.{_options.IdColumnName}
    FROM {_options.OriginIkpuTableName} AS child
    WHERE child._id_parent = parent.{_options.IdColumnName}
)  AND unit.{_options.IdColumnName} IS NULL";

            using var command = new SqlCommand(sql, connection);
            using var reader = await command.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false);

            while (await reader.ReadAsync(cancellationToken).ConfigureAwait(false))
            {
                var id = reader.GetGuid(0);
                var code = reader.GetString(1);

                yield return new IdCode(id, code);
            }
        }

        private async Task<IkpuResponse> LoadIkpuUnitAsync(IdCode ikpuIdCode, CancellationToken cancellationToken = default)
        {
            var url = _options.ServiceUrl;
            if (url.EndsWith('/'))
                url += ikpuIdCode.Code;
            else
                url += $"/{ikpuIdCode.Code}";

            var uri = new Uri(url);

            var response = await _httpClient.GetAsync(url, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                var ikpuResponse = JsonHelper.FromJson<IkpuResponse>(jsonResponse);

                if (!ikpuResponse.Success)
                {
                    throw new Exception($"{nameof(IkpuResponse)} has {nameof(IkpuResponse.Success)} = false.{Environment.NewLine}Original Json:{Environment.NewLine}{jsonResponse}");
                }

                return ikpuResponse;
            }
            catch (JsonException ex)
            {
                throw;
            }
        }

        private async Task SaveIkpuUnitAsync(IEnumerable<(IdCode idCode, IkpuResponse ikpuResponse)> unitsToInsert, CancellationToken cancellationToken = default)
        {
            using var connection = new SqlConnection(_options.ConnectrionString);
            await connection.OpenAsync(cancellationToken).ConfigureAwait(false);

            using var trans = await connection.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                await InsertUnitsAsync(unitsToInsert, connection, trans, cancellationToken).ConfigureAwait(false);

                await trans.CommitAsync(cancellationToken).ConfigureAwait(false);
            }
            catch
            {
                if (trans.Connection != null)
                {
                    await trans.RollbackAsync(cancellationToken).ConfigureAwait(false);
                }

                throw;
            }
        }

        private async Task InsertUnitsAsync(IEnumerable<(IdCode idCode, IkpuResponse ikpuResponse)> unitsToInsert, SqlConnection connection, DbTransaction trans, CancellationToken cancellationToken = default)
        {
            // Create a DataTable to hold the data
            var goodDataTable = new DataTable();
            goodDataTable.Columns.Add("IdClassifierCode", typeof(Guid));
            goodDataTable.Columns.Add(nameof(PackageName.Code), typeof(string));
            goodDataTable.Columns.Add(nameof(PackageName.PackageType), typeof(string));
            goodDataTable.Columns.Add(nameof(PackageName.NameUz), typeof(string));
            goodDataTable.Columns.Add(nameof(PackageName.NameRu), typeof(string));
            goodDataTable.Columns.Add(nameof(PackageName.NameLat), typeof(string));

            // Populate the DataTable with the data
            foreach (var (idCode, ikpuResponse) in unitsToInsert)
            {
                foreach (var package in ikpuResponse.Data)
                {
                    var row = goodDataTable.NewRow();
                    row["IdClassifierCode"] = idCode.Id;
                    row[nameof(PackageName.Code)] = package.Code;
                    row[nameof(PackageName.PackageType)] = package.PackageType;
                    row[nameof(PackageName.NameUz)] = package.NameUz;
                    row[nameof(PackageName.NameRu)] = package.NameRu;
                    row[nameof(PackageName.NameLat)] = package.NameLat;

                    goodDataTable.Rows.Add(row);
                }
            }

            var copyOptions = SqlBulkCopyOptions.CheckConstraints;

            using var sqlBulkCopy = new SqlBulkCopy(connection, copyOptions, (SqlTransaction)trans);
            sqlBulkCopy.BulkCopyTimeout = BulkInsertTimeout;
            sqlBulkCopy.BatchSize = BulkInsertBatchSize;
            sqlBulkCopy.DestinationTableName = _options.TargetIkpuUnitTableName;

            sqlBulkCopy.ColumnMappings.Add("IdClassifierCode", "_id_classifier_code");
            sqlBulkCopy.ColumnMappings.Add(nameof(PackageName.Code), "_code");
            sqlBulkCopy.ColumnMappings.Add(nameof(PackageName.PackageType), "_package_type");
            sqlBulkCopy.ColumnMappings.Add(nameof(PackageName.NameUz), "_name_uz");
            sqlBulkCopy.ColumnMappings.Add(nameof(PackageName.NameRu), "_name_ru");
            sqlBulkCopy.ColumnMappings.Add(nameof(PackageName.NameLat), "_name_lat");

            await sqlBulkCopy.WriteToServerAsync(goodDataTable, cancellationToken).ConfigureAwait(false);
        }
    }
}
