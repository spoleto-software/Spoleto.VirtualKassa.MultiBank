using Microsoft.Extensions.Configuration;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.Tests
{
    public static class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddUserSecrets("909bb98f-e826-4d1c-81e1-57b2994c8d63")
               .Build();
        }

        public static MultiBankOption GetMultiBankSettings()
        {
            var settings = _config.GetSection(nameof(MultiBankOption)).Get<MultiBankOption>();

            return settings;
        }

        public static string GetBearerToken()
        {
            var token = _config.GetSection("BearerToken").Value;

            return token;
        }

        public static CashRegisterSettings GetCashRegisterSettings()
        {
            var settings = _config.GetSection(nameof(CashRegisterSettings)).Get<CashRegisterSettings>();

            return settings;
        }

        public static CashierLoginInfo GetCashierLoginInfo()
        {
            var loginInfo = _config.GetSection(nameof(CashierLoginInfo)).Get<CashierLoginInfo>();

            return loginInfo;
        }

        public static SaleSlip GetSaleSlip()
        {
            var saleSlip = _config.GetSection(nameof(SaleSlip)).Get<SaleSlip>();

            return saleSlip;
        }

        public static ReturnSlip GetReturnSlip()
        {
            var returnSlip = _config.GetSection(nameof(ReturnSlip)).Get<ReturnSlip>();

            return returnSlip;
        }

        public static AdvanceSlip GetAdvanceSlip()
        {
            var advanceSlip = _config.GetSection(nameof(AdvanceSlip)).Get<AdvanceSlip>();

            return advanceSlip;
        }

        public static AdditionalAdvanceSlip GetAdditionalAdvanceSlip()
        {
            var additionalAdvanceSlip = _config.GetSection(nameof(AdditionalAdvanceSlip)).Get<AdditionalAdvanceSlip>();

            return additionalAdvanceSlip;
        }

        public static CreditSlip GetCreditSlip()
        {
            var creditSlip = _config.GetSection(nameof(CreditSlip)).Get<CreditSlip>();

            return creditSlip;
        }

        public static SendMailRequest GetSendMailRequest()
        {
            var sendMailRequest = _config.GetSection(nameof(SendMailRequest)).Get<SendMailRequest>();

            return sendMailRequest;
        }

        public static OpenShiftRequest GetOpenShiftRequest()
        {
            var openShiftRequest = _config.GetSection(nameof(OpenShiftRequest)).Get<OpenShiftRequest>();

            return openShiftRequest;
        }

        public static CloseShiftRequest GetCloseShiftRequest()
        {
            var closeShiftRequest = _config.GetSection(nameof(CloseShiftRequest)).Get<CloseShiftRequest>();

            return closeShiftRequest;
        }

        public static XReportRequest GetXReportRequest()
        {
            var xReportRequest = _config.GetSection(nameof(XReportRequest)).Get<XReportRequest>();

            return xReportRequest;
        }
    }
}
