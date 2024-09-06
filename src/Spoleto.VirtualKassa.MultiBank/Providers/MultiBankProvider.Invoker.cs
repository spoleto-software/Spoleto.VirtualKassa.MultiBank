using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Extensions;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank
{
    public partial class MultiBankProvider
    {
        private record TokenInfo(string TokenType, string TokenValue);

        private readonly HttpClient _httpClient;

        private TokenInfo? _tokenInfo;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MultiBankProvider()
            : this(new HttpClient())
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="MultiBankProvider"/>.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> instance.</param>
        public MultiBankProvider(HttpClient httpClient)
        {
            if (httpClient is null)
                throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _httpClient.ConfigureHttpClient();
        }

        private async Task<T> InvokeAsync<T>(MultiBankOption settings, Uri uri, HttpMethod method, string? requestJsonContent = null, bool throwIfUnsuccess = true, bool allowToRelogin = true, [CallerMemberName] string methodName = "") where T : IMultiBankResponse
        {
            using var requestMessage = new HttpRequestMessage(method, uri);
            InitRequestHeaders(requestMessage);

            await Authenticate(settings, methodName, requestMessage).ConfigureAwait(false);

            if (requestJsonContent != null)
            {
                requestMessage.Content = new StringContent(requestJsonContent, DefaultSettings.Encoding, DefaultSettings.ContentType);
            }

            using var responseMessage = await _httpClient.SendAsync(requestMessage).ConfigureAwait(false);

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

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized
                && allowToRelogin)
            {
                _tokenInfo = null;

                return await InvokeAsync<T>(settings, uri, method, requestJsonContent, throwIfUnsuccess, false, methodName).ConfigureAwait(false);
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

        protected virtual async Task Authenticate(MultiBankOption settings, string methodName, HttpRequestMessage requestMessage)
        {
            if (!String.IsNullOrEmpty(settings.UserName)
                && !String.IsNullOrEmpty(settings.Password)
                && !String.IsNullOrEmpty(settings.ProfileId)
                && !String.IsNullOrEmpty(settings.ProfileOfUserId))
            {
                if (MethodNeedsToLogin(methodName))
                {
                    if (_tokenInfo == null)
                    {
                        var loginInfo = new CashierLoginInfo
                        {
                            Username = settings.UserName,
                            Password = settings.Password,
                            ProfileId = settings.ProfileId,
                            ProfileOfUserId = settings.ProfileOfUserId
                        };

                        var result = await CashierLoginAsync(settings, loginInfo).ConfigureAwait(false);
                        if (result != null
                            && result.Success
                            && result.Token?.Data != null)
                        {
                            _tokenInfo = new TokenInfo(result.Token.Data.TokenType, result.Token.Data.AccessToken);
                        }
                    }

                    if (_tokenInfo != null)
                    {
                        requestMessage.Headers.Authorization = new AuthenticationHeaderValue(_tokenInfo.TokenType, _tokenInfo.TokenValue);
                    }
                }
            }
        }

        protected virtual bool MethodNeedsToLogin(string methodName)
        {
            return methodName == nameof(MultiBankProvider.OpenShiftAsync)
                || methodName == nameof(MultiBankProvider.CloseShiftAsync)
                || methodName == nameof(MultiBankProvider.SellAsync)
                || methodName == nameof(MultiBankProvider.ReturnAsync)
                || methodName == nameof(MultiBankProvider.XReportAsync)
                || methodName == nameof(MultiBankProvider.AdvanceSlipAsync)
                || methodName == nameof(MultiBankProvider.AdditionalAdvanceSlipAsync)
                || methodName == nameof(MultiBankProvider.CreditSlipAsync)
                || methodName == nameof(MultiBankProvider.AddMyIkpuAsync)
                || methodName == nameof(MultiBankProvider.RemoveMyIkpuAsync);
        }

        private void InitRequestHeaders(HttpRequestMessage requestMessage)
        {
            requestMessage.ConfigureRequestMessage();
        }
    }
}
