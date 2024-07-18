using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank
{
    /// <summary>
    /// MultiBank provider.
    /// </summary>
    public partial class MultiBankProvider : IMultiBankProvider
    {
        private static string GetUrlPrefix(MultiBankOption settings) => $"api/{settings.VersionApi}/";

        public async Task<DriverConfiguration> GetDriverConfigurationAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}fiscal/set_up_fm");

            var result = await InvokeAsync<DriverConfiguration>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<FiscalModuleInfo> GetFiscalModuleInfoAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}info");

            var result = await InvokeAsync<FiscalModuleInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<FiscalModuleStatus> GetFiscalModuleStatusAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}status");

            var result = await InvokeAsync<FiscalModuleStatus>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashRegisterResponse> SetCashRegisterSettingsAsync(MultiBankOption settings, CashRegisterSettings cashRegisterSettings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}cashbox");

            var jsonModel = JsonHelper.ToJson(cashRegisterSettings);

            var result = await InvokeAsync<CashRegisterResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<CashRegisterResponse> GetCashRegisterSettingsAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}cashbox");

            var result = await InvokeAsync<CashRegisterResponse>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CompanyInfo> GetCompanyDataAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}contragents");

            var result = await InvokeAsync<CompanyInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashiersInfo> GetCashiersAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}cashiers");

            var result = await InvokeAsync<CashiersInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<CashierLoginResponse> CashierLoginAsync(MultiBankOption settings, CashierLoginInfo loginInfo)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}auth/login");

            var jsonModel = JsonHelper.ToJson(loginInfo);

            var result = await InvokeAsync<CashierLoginResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<CashierExternalLoginResponse> CashierExternalLoginAsync(MultiBankOption settings, CashierExternalLoginInfo loginInfo)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}auth/external/login");

            var jsonModel = JsonHelper.ToJson(loginInfo);

            var result = await InvokeAsync<CashierExternalLoginResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }


        public async Task<SellResultInfo> SellAsync(MultiBankOption settings, SaleSlip saleSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(saleSlip);

            var result = await InvokeAsync<SellResultInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<ReturnResultInfo> ReturnAsync(MultiBankOption settings, ReturnSlip returnSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(returnSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<ReturnResultInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<UseProfileInfo> GetProfilesForAuthorizationAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}auth/external/profiles");

            var result = await InvokeAsync<UseProfileInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<AttachProfileResponse> AttachProfileToTokenAsync(MultiBankOption settings, ProfileToAttach profileToAttach)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}auth/external/profiles");

            var jsonModel = JsonHelper.ToJson(profileToAttach);

            var result = await InvokeAsync<AttachProfileResponse>(settings, uri, HttpMethod.Post, requestJsonContent: jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<NomenclaturesInfo> GetNomenclatureListAsync(MultiBankOption settings, bool refresh)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products{(refresh ? "?refresh=1" : String.Empty)}");

            var result = await InvokeAsync<NomenclaturesInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<SendMailResponse> SendSaleSlipByEmailAsync(MultiBankOption settings, SendMailRequest sendMailRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}sendMail");

            var jsonModel = JsonHelper.ToJson(sendMailRequest);

            var result = await InvokeAsync<SendMailResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<ShiftResponse> OpenShiftAsync(MultiBankOption settings, OpenShiftRequest openShiftRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(openShiftRequest);

            var result = await InvokeAsync<ShiftResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<ShiftResponse> CloseShiftAsync(MultiBankOption settings, CloseShiftRequest closeShiftRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(closeShiftRequest);

            var result = await InvokeAsync<ShiftResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<XReportInfo> XReportAsync(MultiBankOption settings, XReportRequest xReportRequest)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(xReportRequest);

            var result = await InvokeAsync<XReportInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<AdvanceSlipInfo> AdvanceSlipAsync(MultiBankOption settings, AdvanceSlip advanceSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(advanceSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<AdvanceSlipInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<AdditionalAdvanceSlipInfo> AdditionalAdvanceSlipAsync(MultiBankOption settings, AdditionalAdvanceSlip additionalAdvanceSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(additionalAdvanceSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<AdditionalAdvanceSlipInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<CreditSlipInfo> CreditSlipAsync(MultiBankOption settings, CreditSlip creditSlip)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}operations");

            var jsonModel = JsonHelper.ToJson(creditSlip);

            //todo: проверять что возвращается в роли результата операции
            var result = await InvokeAsync<CreditSlipInfo>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusInfo> GetIkpuListAsync(MultiBankOption settings, string parentNode = "root")
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/ikpu_info?node={parentNode}");

            var result = await InvokeAsync<IkpusInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<MyIkpusInfo> GetMyIkpuListAsync(MultiBankOption settings)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/myikpu");

            var result = await InvokeAsync<MyIkpusInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<AddMyIkpuResponse> AddMyIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/myikpu");

            var jsonModel = JsonHelper.ToJson(new Dictionary<string, string> { { nameof(mxikCode), mxikCode } });

            var result = await InvokeAsync<AddMyIkpuResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return result;
        }

        public async Task RemoveMyIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/myikpu");

            var jsonModel = JsonHelper.ToJson(new Dictionary<string, string> { { nameof(mxikCode), mxikCode } });

            var result = await InvokeAsync<EmptyResponse>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuTextFilter ikpuTextFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuTextFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuCodeFilter ikpuCodeFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuCodeFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuGtinFilter ikpuGtinFilter)
        {
            var queryString = HttpHelper.ToQueryString(ikpuGtinFilter);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/by_params?{queryString}");

            var result = await InvokeAsync<IkpusSearchResult>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpuChangeHistory> GetIkpuChangeHistoryAsync(MultiBankOption settings, string catalogCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/ikpu_history?catalogCode={catalogCode}");

            var result = await InvokeAsync<IkpuChangeHistory>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<IkpuCheckInfo> CheckIkpuAsync(MultiBankOption settings, string mxikCode)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}products/check?mxikCode={mxikCode}");

            var result = await InvokeAsync<IkpuCheckInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }

        public async Task<SlipsInfo> GetSlipListAsync(MultiBankOption settings, SlipCriteria slipCriteria)
        {
            var queryString = HttpHelper.ToQueryString(slipCriteria);
            var uri = new Uri(new Uri(settings.ServiceUrl), $"{GetUrlPrefix(settings)}receipts?{queryString}");

            var result = await InvokeAsync<SlipsInfo>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return result;
        }
    }
}
