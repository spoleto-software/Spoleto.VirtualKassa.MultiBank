using System.Net.Http.Headers;
using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Extensions;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.Providers
{
    public partial class MultiBankProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _urlPrefix;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="httpClientFactory"></param>
        public MultiBankProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _urlPrefix = "api/v1/"; //todo: ?
        }

        private async Task<T> InvokeAsync<T>(Uri uri, HttpMethod method, string? requestJsonContent = null, bool throwIfUnsuccess = true, string? bearerToken = null) where T : IMultiBankResponse
        {
            var client = _httpClientFactory.CreateClient();
            client.ConfigureHttpClient();

            using var requestMessage = new HttpRequestMessage(method, uri);
            InitRequestHeaders(requestMessage);

            if (requestJsonContent != null)
            {
                requestMessage.Content = new StringContent(requestJsonContent, DefaultSettings.Encoding, DefaultSettings.ContentType);
            }

            if (bearerToken != null)
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            }

            using var responseMessage = await client.SendAsync(requestMessage).ConfigureAwait(false);

            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (String.IsNullOrEmpty(result))
                    return default;

                var objectResult = JsonHelper.FromJson<T>(result);
                if (throwIfUnsuccess
                    && !objectResult.Success)
                {
                    throw new Exception($"{result}.");
                }

                return objectResult;
            }

            var errorResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            Exception exception;
            if (!String.IsNullOrEmpty(errorResult))
            {
                exception = new Exception(errorResult);
            }
            else
            {
                exception = new Exception($"{nameof(responseMessage.StatusCode)}: {responseMessage.StatusCode}." +
                    $"{Environment.NewLine}{nameof(responseMessage.ReasonPhrase)}: {responseMessage.ReasonPhrase}.");
            }

            exception.InitializeException(responseMessage);

            throw exception;
        }


        private void InitRequestHeaders(HttpRequestMessage requestMessage)
        {
            requestMessage.ConfigureRequestMessage();
        }
    }
}
