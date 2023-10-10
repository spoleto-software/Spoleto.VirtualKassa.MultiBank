using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.Providers
{
    /// <summary>
    /// MultiBank provider.
    /// </summary>
    public interface IMultiBankProvider
    {
        /// <summary>
        /// Method to get the driver configuration
        /// </summary>
        DriverConfiguration GetDriverConfiguration(MultiBankOption settings) => GetDriverConfigurationAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the driver configuration
        /// </summary>
        Task<DriverConfiguration> GetDriverConfigurationAsync(MultiBankOption settings);

        /// <summary>
        /// Method to get information about the fiscal module
        /// </summary>
        FiscalModuleInfo GetFiscalModuleInfo(MultiBankOption settings) => GetFiscalModuleInfoAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get information about the fiscal module
        /// </summary>
        Task<FiscalModuleInfo> GetFiscalModuleInfoAsync(MultiBankOption settings);

        /// <summary>
        /// Method to get status of the fiscal module
        /// </summary>
        FiscalModuleStatus GetFiscalModuleStatus(MultiBankOption settings) => GetFiscalModuleStatusAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get status of the fiscal module
        /// </summary>
        Task<FiscalModuleStatus> GetFiscalModuleStatusAsync(MultiBankOption settings);

        /// <summary>
        /// Method to get the cash register settings
        /// </summary>
        CashRegisterResponse GetCashRegisterSettings(MultiBankOption settings)
            => GetCashRegisterSettingsAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the cash register settings
        /// </summary>
        Task<CashRegisterResponse> GetCashRegisterSettingsAsync(MultiBankOption settings);

        /// <summary>
        /// Method to set the cash register settings
        /// </summary>
        CashRegisterResponse SetCashRegisterSettings(MultiBankOption settings, CashRegisterSettings cashRegisterSettings)
            => SetCashRegisterSettingsAsync(settings, cashRegisterSettings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to set the cash register settings
        /// </summary>
        Task<CashRegisterResponse> SetCashRegisterSettingsAsync(MultiBankOption settings, CashRegisterSettings cashRegisterSettings);

        /// <summary>
        /// Method to get company data
        /// </summary>
        CompanyInfo GetCompanyData(MultiBankOption settings) => GetCompanyDataAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get company data
        /// </summary>
        Task<CompanyInfo> GetCompanyDataAsync(MultiBankOption settings);

        /// <summary>
        /// Method to get the list of cashiers
        /// </summary>
        CashiersInfo GetCashiers(MultiBankOption settings) => GetCashiersAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of cashiers
        /// </summary>
        Task<CashiersInfo> GetCashiersAsync(MultiBankOption settings);

        /// <summary>
        /// Method for cashier login (authentication)
        /// </summary>
        CashierLoginResponse CashierLogin(MultiBankOption settings, CashierLoginInfo loginInfo)
            => CashierLoginAsync(settings, loginInfo).GetAwaiter().GetResult();

        /// <summary>
        /// Async method for cashier login (authentication)
        /// </summary>
        Task<CashierLoginResponse> CashierLoginAsync(MultiBankOption settings, CashierLoginInfo loginInfo);

        /// <summary>
        /// Method to perform a sale transaction
        /// </summary>
        SellResultInfo Sell(MultiBankOption settings, SaleSlip saleSlip)
            => SellAsync(settings, saleSlip).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to perform a sale transaction
        /// </summary>
        Task<SellResultInfo> SellAsync(MultiBankOption settings, SaleSlip saleSlip);

        /// <summary>
        /// Method to perform a refund transaction
        /// </summary>
        ReturnResultInfo Return(MultiBankOption settings, ReturnSlip returnSlip)
            => ReturnAsync(settings, returnSlip).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to perform a refund transaction
        /// </summary>
        Task<ReturnResultInfo> ReturnAsync(MultiBankOption settings, ReturnSlip returnSlip);

        /// <summary>
        /// Method to get the list of profiles for authorization
        /// </summary>
        UseProfileInfo GetProfilesForAuthorization(MultiBankOption settings, string bearerToken) => GetProfilesForAuthorizationAsync(settings, bearerToken).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of profiles for authorization
        /// </summary>
        Task<UseProfileInfo> GetProfilesForAuthorizationAsync(MultiBankOption settings, string bearerToken);

        /// <summary>
        /// Method to attach a profile to the token
        /// </summary>
        AttachProfileResponse AttachProfileToToken(MultiBankOption settings, string bearerToken, ProfileToAttach profileToAttach) => AttachProfileToTokenAsync(settings, bearerToken, profileToAttach).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to attach a profile to the token
        /// </summary>
        Task<AttachProfileResponse> AttachProfileToTokenAsync(MultiBankOption settings, string bearerToken, ProfileToAttach profileToAttach);

        /// <summary>
        /// Method to get the list of nomenclatures.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="refresh">Update products from the system or not?</param>
        /// <returns></returns>
        NomenclaturesInfo GetNomenclatureList(MultiBankOption settings, bool refresh) => GetNomenclatureListAsync(settings, refresh).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of nomenclatures
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="refresh">Update products from the system or not?</param>
        /// <returns></returns>
        Task<NomenclaturesInfo> GetNomenclatureListAsync(MultiBankOption settings, bool refresh);

        /// <summary>
        /// Method to send a sale slip by email
        /// </summary>
        SendMailResponse SendSaleSlipByEmail(MultiBankOption settings, SendMailRequest sendMailRequest) => SendSaleSlipByEmailAsync(settings, sendMailRequest).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to send a sale slip by email
        /// </summary>
        Task<SendMailResponse> SendSaleSlipByEmailAsync(MultiBankOption settings, SendMailRequest sendMailRequest);

        /// <summary>
        /// Method to open a shift
        /// </summary>
        void OpenShift(MultiBankOption settings, OpenShiftRequest openShiftRequest) => OpenShiftAsync(settings, openShiftRequest).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to open a shift
        /// </summary>
        Task OpenShiftAsync(MultiBankOption settings, OpenShiftRequest openShiftRequest);

        /// <summary>
        /// Async method to close the shift
        /// </summary>
        void CloseShift(MultiBankOption settings, CloseShiftRequest closeShiftRequest) => CloseShiftAsync(settings, closeShiftRequest).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to close the shift
        /// </summary>
        Task CloseShiftAsync(MultiBankOption settings, CloseShiftRequest closeShiftRequest);

        /// <summary>
        /// Async method to get X report
        /// </summary>
        XReportInfo XReport(MultiBankOption settings, XReportRequest xReportRequest) => XReportAsync(settings, xReportRequest).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get X report
        /// </summary>
        Task<XReportInfo> XReportAsync(MultiBankOption settings, XReportRequest xReportRequest);

        /// <summary>
        /// Method to make an advance slip
        /// </summary>
        AdvanceSlipInfo AdvanceSlip(MultiBankOption settings, AdvanceSlip advanceSlip)
            => AdvanceSlipAsync(settings, advanceSlip).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to make an advance slip
        /// </summary>
        Task<AdvanceSlipInfo> AdvanceSlipAsync(MultiBankOption settings, AdvanceSlip advanceSlip);

        /// <summary>
        /// Method to make an additional advance slip
        /// </summary>
        AdditionalAdvanceSlipInfo AdditionalAdvanceSlip(MultiBankOption settings, AdditionalAdvanceSlip advanceSlip)
            => AdditionalAdvanceSlipAsync(settings, advanceSlip).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to make an additional advance slip
        /// </summary>
        Task<AdditionalAdvanceSlipInfo> AdditionalAdvanceSlipAsync(MultiBankOption settings, AdditionalAdvanceSlip advanceSlip);

        /// <summary>
        /// Method to make a credit slip
        /// </summary>
        CreditSlipInfo CreditSlip(MultiBankOption settings, CreditSlip creditSlip)
            => CreditSlipAsync(settings, creditSlip).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to make a credit slip
        /// </summary>
        Task<CreditSlipInfo> CreditSlipAsync(MultiBankOption settings, CreditSlip creditSlip);

        #region IKPU
        /// <summary>
        /// Method to get the list of IKPU.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="parentNode">The parent node. For main items use node with the name: "root".</param>
        /// <returns></returns>
        IkpusInfo GetIkpuList(MultiBankOption settings, string parentNode = "root") => GetIkpuListAsync(settings, parentNode).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of IKPU
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="parentNode">The parent node. For main items use node with the name: "root".</param>
        /// <returns></returns>
        Task<IkpusInfo> GetIkpuListAsync(MultiBankOption settings, string parentNode = "root");

        /// <summary>
        /// Method to get the list of my IKPU (added to Favorite list).
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <returns></returns>
        MyIkpusInfo GetMyIkpuList(MultiBankOption settings) => GetMyIkpuListAsync(settings).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of my IKPU (added to Favorite list)
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <returns></returns>
        Task<MyIkpusInfo> GetMyIkpuListAsync(MultiBankOption settings);

        /// <summary>
        /// Method to add IKPU to Favorite list.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The IKPU code.</param>
        /// <returns></returns>
        AddMyIkpuResponse AddMyIkpu(MultiBankOption settings, string mxikCode) => AddMyIkpuAsync(settings, mxikCode).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to add IKPU to Favorite list.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The IKPU code.</param>
        /// <returns></returns>
        Task<AddMyIkpuResponse> AddMyIkpuAsync(MultiBankOption settings, string mxikCode);

        /// <summary>
        /// Method to remove IKPU from Favorite list.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The IKPU code.</param>
        /// <returns></returns>
        void RemovedMyIkpu(MultiBankOption settings, string mxikCode) => RemoveMyIkpuAsync(settings, mxikCode).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to remove IKPU from Favorite list.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The IKPU code.</param>
        /// <returns></returns>
        Task RemoveMyIkpuAsync(MultiBankOption settings, string mxikCode);

        /// <summary>
        /// Method to find the list of IKPU by text.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuTextFilter">The text filter.</param>
        /// <returns></returns>
        IkpusSearchResult FindIkpuList(MultiBankOption settings, IkpuTextFilter ikpuTextFilter) => FindIkpuListAsync(settings, ikpuTextFilter).GetAwaiter().GetResult();

        /// <summary>
        /// Async method tofind the list of IKPU by text
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuTextFilter">The text filter.</param>
        /// <returns></returns>
        Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuTextFilter ikpuTextFilter);

        /// <summary>
        /// Method to find the list of IKPU by code.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuCodeFilter">The code filter.</param>
        /// <returns></returns>
        IkpusSearchResult FindIkpuList(MultiBankOption settings, IkpuCodeFilter ikpuCodeFilter) => FindIkpuListAsync(settings, ikpuCodeFilter).GetAwaiter().GetResult();

        /// <summary>
        /// Async method tofind the list of IKPU by code
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuCodeFilter">The code filter.</param>
        /// <returns></returns>
        Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuCodeFilter ikpuCodeFilter);

        /// <summary>
        /// Method to find the list of IKPU by GTIN.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuGtinFilter">The GTIN filter.</param>
        /// <returns></returns>
        IkpusSearchResult FindIkpuList(MultiBankOption settings, IkpuGtinFilter ikpuGtinFilter) => FindIkpuListAsync(settings, ikpuGtinFilter).GetAwaiter().GetResult();

        /// <summary>
        /// Async method tofind the list of IKPU by GTIN
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="ikpuGtinFilter">The GTIN filter.</param>
        /// <returns></returns>
        Task<IkpusSearchResult> FindIkpuListAsync(MultiBankOption settings, IkpuGtinFilter ikpuGtinFilter);

        /// <summary>
        /// Method to get the history of changes for the specified IKPU.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="catalogCode">The catalog code of the specified IKPU.</param>
        /// <returns></returns>
        IkpuChangeHistory GetIkpuChangeHistory(MultiBankOption settings, string catalogCode) => GetIkpuChangeHistoryAsync(settings, catalogCode).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the history of changes for the specified IKPU.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="catalogCode">The catalog code of the specified IKPU.</param>
        /// <returns></returns>
        Task<IkpuChangeHistory> GetIkpuChangeHistoryAsync(MultiBankOption settings, string catalogCode);

        /// <summary>
        /// Method to check the information of the specified IKPU.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The code of the specified IKPU.</param>
        /// <returns></returns>
        IkpuCheckInfo CheckIkpu(MultiBankOption settings, string mxikCode) => CheckIkpuAsync(settings, mxikCode).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to check the information of the specified IKPU.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="mxikCode">The code of the specified IKPU.</param>
        /// <returns></returns>
        Task<IkpuCheckInfo> CheckIkpuAsync(MultiBankOption settings, string mxikCode);
        #endregion

        #region Slips
        ///// <summary>
        ///// Method to resend all slips
        ///// </summary>
        //ResendSlipInfo ResendSlips(MultiBankOption settings)
        //    => ResendSlipsAsync(settings).GetAwaiter().GetResult();

        ///// <summary>
        ///// Async method to resend all slips
        ///// </summary>
        //Task<ResendSlipInfo> ResendSlipsAsync(MultiBankOption settings);

        /// <summary>
        /// Method to get the list of slips.
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="slipCriteria">The criteria to get slips.</param>
        /// <returns></returns>
        SlipsInfo GetSlipList(MultiBankOption settings, SlipCriteria slipCriteria) => GetSlipListAsync(settings, slipCriteria).GetAwaiter().GetResult();

        /// <summary>
        /// Async method to get the list of slips
        /// </summary>
        /// <param name="settings">The API settings.</param>
        /// <param name="slipCriteria">The criteria to get slips.</param>
        /// <returns></returns>
        Task<SlipsInfo> GetSlipListAsync(MultiBankOption settings, SlipCriteria slipCriteria);
        #endregion
    }
}
