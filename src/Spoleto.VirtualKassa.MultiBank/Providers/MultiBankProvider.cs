using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Helpers;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.Providers
{
    /// <summary>
    /// MultiBank provider.
    /// </summary>
    public partial class MultiBankProvider : IMultiBankProvider
    {
        public async Task<DriverConfiguration> GetDriverConfigurationAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}fiscal/set_up_fm");

            var result = await InvokeAsync<DriverConfiguration>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<FiscalModuleInfo> GetFiscalModuleInfoAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}info");

            var result = await InvokeAsync<FiscalModuleInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<FiscalModuleStatus> GetFiscalModuleStatusAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}status");

            var result = await InvokeAsync<FiscalModuleStatus>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashRegisterResponse> SetCashRegisterSettingsAsync(MultiBankOption settings, CashRegisterSettings cashRegisterSettings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}cashbox");

            var jsonModel = JsonHelper.ToJson(cashRegisterSettings);

            var result = await InvokeAsync<CashRegisterResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<CashRegisterResponse> GetCashRegisterSettingsAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}cashbox");

            var result = await InvokeAsync<CashRegisterResponse>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CompanyInfo> GetCompanyDataAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}contragents");

            var result = await InvokeAsync<CompanyInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashiersInfo> GetCashiersAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}cashiers");

            var result = await InvokeAsync<CashiersInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashierLoginResponse> CashierLoginAsync(MultiBankOption settings, CashierLoginInfo loginInfo)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}auth/login");

            var jsonModel = JsonHelper.ToJson(loginInfo);

            var result = await InvokeAsync<CashierLoginResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<SellResultInfo> SellAsync(MultiBankOption settings, SaleSlip saleSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(saleSlip);

            var result = await InvokeAsync<SellResultInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<ReturnResultInfo> ReturnAsync(MultiBankOption settings, ReturnSlip returnSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(returnSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<ReturnResultInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<UseProfileInfo> GetProfilesForAuthorizationAsync(MultiBankOption settings, string bearerToken)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}auth/external/profiles");

            var result = await InvokeAsync<UseProfileInfo>(uri, HttpMethod.Get, bearerToken: bearerToken).ConfigureAwait(false);

            return result;
        }

        public async Task<AttachProfileResponse> AttachProfileToTokenAsync(MultiBankOption settings, string bearerToken, ProfileToAttach profileToAttach)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}auth/external/profiles");

            var jsonModel = JsonHelper.ToJson(profileToAttach);

            var result = await InvokeAsync<AttachProfileResponse>(uri, HttpMethod.Post, requestJsonContent: jsonModel, bearerToken: bearerToken).ConfigureAwait(false);

            return result;
        }

        public async Task<NomenclaturesInfo> GetNomenclatureListAsync(MultiBankOption settings, bool refresh)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products{(refresh ? "?refresh=1" : String.Empty)}");

            var result = await InvokeAsync<NomenclaturesInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<SendMailResponse> SendSaleSlipByEmailAsync(MultiBankOption settings, SendMailRequest sendMailRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}sendMail");

            var jsonModel = JsonHelper.ToJson(sendMailRequest);

            var result = await InvokeAsync<SendMailResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task OpenShiftAsync(MultiBankOption settings, OpenShiftRequest openShiftRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(openShiftRequest);

            var result = await InvokeAsync<EmptyResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);
        }

        public async Task CloseShiftAsync(MultiBankOption settings, CloseShiftRequest closeShiftRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(closeShiftRequest);

            var result = await InvokeAsync<EmptyResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);
        }

        public async Task<XReportInfo> XReportAsync(MultiBankOption settings, XReportRequest xReportRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(xReportRequest);

            var result = await InvokeAsync<XReportInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<AdvanceSlipInfo> AdvanceSlipAsync(MultiBankOption settings, AdvanceSlip advanceSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(advanceSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<AdvanceSlipInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<AdditionalAdvanceSlipInfo> AdditionalAdvanceSlipAsync(MultiBankOption settings, AdditionalAdvanceSlip additionalAdvanceSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(additionalAdvanceSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<AdditionalAdvanceSlipInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<CreditSlipInfo> CreditSlipAsync(MultiBankOption settings, CreditSlip creditSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}operations");

            var jsonModel = JsonHelper.ToJson(creditSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<CreditSlipInfo>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusInfo> GetIkpuListAsync(MultiBankOption settings, string parentNode = "root")
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/ikpu_info?node={parentNode}");

            var result = await InvokeAsync<IkpusInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<MyIkpusInfo> GetMyIkpuListAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/myikpu");

            var result = await InvokeAsync<MyIkpusInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<AddMyIkpuResponse> AddMyIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/myikpu");

            var jsonModel = JsonHelper.ToJson(new Dictionary<string, string> { { nameof(mxikCode), mxikCode } });

            var result = await InvokeAsync<AddMyIkpuResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task RemoveMyIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/myikpu");

            var jsonModel = JsonHelper.ToJson(new Dictionary<string, string> { { nameof(mxikCode), mxikCode } });

            var result = await InvokeAsync<EmptyResponse>(uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuTextFilter ikpuTextFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuTextFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuCodeFilter ikpuCodeFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuCodeFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuGtinFilter ikpuGtinFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuGtinFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpuChangeHistory> GetIkpuChangeHistoryAsync(MultiBankOption settings, string catalogCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/ikpu_history?catalogCode={catalogCode}");

            var result = await InvokeAsync<IkpuChangeHistory>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpuCheckInfo> CheckIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/check?mxikCode={mxikCode}");

            var result = await InvokeAsync<IkpuCheckInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<SlipsInfo> GetSlipListAsync(MultiBankOption settings, SlipCriteria slipCriteria)
        {
            var queryString = HttpHelper.ToQueryString(slipCriteria);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{_urlPrefix}products/receipts?{queryString}");

            var result = await InvokeAsync<SlipsInfo>(uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }
    }
}
