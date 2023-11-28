using Microsoft.Extensions.DependencyInjection;
using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Models;
using Spoleto.VirtualKassa.MultiBank.Providers;

namespace Spoleto.VirtualKassa.MultiBank.Tests
{
    public class MultiBankTests
    {
        private ServiceProvider _serviceProvider;
        private MultiBankOption _settings;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var services = new ServiceCollection();
            services.AddHttpClient();
            services.AddSingleton<IMultiBankProvider, MultiBankProvider>();

            _serviceProvider = services.BuildServiceProvider();

            _settings = ConfigurationHelper.GetMultiBankSettings();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _serviceProvider.Dispose();
        }

        [Test]
        public async Task GetDriverConfigurationTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetDriverConfigurationAsync(_settings);


            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetFiscalModuleInfoTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;


            // Act
            var result = await multiBankProvider.GetFiscalModuleInfoAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetCompanyDataTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;


            // Act
            var result = await multiBankProvider.GetCompanyDataAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetCashiersTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetCashiersAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task SetCashRegisterSettingTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var settings = ConfigurationHelper.GetCashRegisterSettings();

            // Act
            var result = await multiBankProvider.SetCashRegisterSettingsAsync(_settings, settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task CashierLoginTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var loginInfo = ConfigurationHelper.GetCashierLoginInfo();

            // Act
            var result = await multiBankProvider.CashierLoginAsync(_settings, loginInfo);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task SellTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var saleSlip = ConfigurationHelper.GetSaleSlip();

            // Act
            var result = await multiBankProvider.SellAsync(_settings, saleSlip);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task ReturnTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var returnSlip = ConfigurationHelper.GetReturnSlip();

            // Act
            var result = await multiBankProvider.ReturnAsync(_settings, returnSlip);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetProfilesForAuthorizationTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var token = ConfigurationHelper.GetBearerToken();

            // Act
            var result = await multiBankProvider.GetProfilesForAuthorizationAsync(_settings, token);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetCashRegisterSettingTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetCashRegisterSettingsAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetFiscalModuleStatusTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetFiscalModuleStatusAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetNomenclaturesTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetNomenclatureListAsync(_settings, false);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task SendSaleSlipByEmailTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var request = ConfigurationHelper.GetSendMailRequest();

            // Act
            var result = await multiBankProvider.SendSaleSlipByEmailAsync(_settings, request);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task OpenShiftTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var request = ConfigurationHelper.GetOpenShiftRequest();

            // Act
            var result = await multiBankProvider.OpenShiftAsync(_settings, request);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task CloseShiftTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var request = ConfigurationHelper.GetCloseShiftRequest();


            // Act
            var result = await multiBankProvider.CloseShiftAsync(_settings, request);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task XReportTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var request = ConfigurationHelper.GetXReportRequest();

            // Act
            var result = await multiBankProvider.XReportAsync(_settings, request);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AdvanceSlipTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var advanceSlip = ConfigurationHelper.GetAdvanceSlip();

            // Act
            var result = await multiBankProvider.AdvanceSlipAsync(_settings, advanceSlip);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task AdditionalAdvanceSlipTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var additionalAdvanceSlip = ConfigurationHelper.GetAdditionalAdvanceSlip();

            // Act
            var result = await multiBankProvider.AdditionalAdvanceSlipAsync(_settings, additionalAdvanceSlip);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task CreditSlipTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var creditSlip = ConfigurationHelper.GetCreditSlip();

            // Act
            var result = await multiBankProvider.CreditSlipAsync(_settings, creditSlip);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task GetIkpuListTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetIkpuListAsync(_settings, "root");

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task GetMyIkpuListTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetMyIkpuListAsync(_settings);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task AddMyIkpuTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var mxikCode = "00101001003000000";

            // Act
            var result = await multiBankProvider.AddMyIkpuAsync(_settings, mxikCode);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task RemoveMyIkpuTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var mxikCode = "00101001003000000";

            // Act
            await multiBankProvider.RemoveMyIkpuAsync(_settings, mxikCode);

            // Assert
            Assert.Pass();
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task FindIkpuListByTextTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.FindIkpuListAsync(_settings, new IkpuTextFilter("Шоколад"));

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task FindIkpuListByCodeTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.FindIkpuListAsync(_settings, new IkpuCodeFilter("01905007001002006"));

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task FindIkpuListByGtinTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.FindIkpuListAsync(_settings, new IkpuGtinFilter("4780012960153"));

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task GetIkpuChangeHistoryTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.GetIkpuChangeHistoryAsync(_settings, "08418001001006012");

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task CheckIkpuTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;

            // Act
            var result = await multiBankProvider.CheckIkpuAsync(_settings, "01905012001889002");

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        /// <summary>
        /// Без вызова в WPF
        /// </summary>
        [Test]
        public async Task GetSlipListTest()
        {
            // Arrange
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            var slipCriteria = new SlipCriteria { Limit = 50 };

            // Act
            var result = await multiBankProvider.GetSlipListAsync(_settings, slipCriteria);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}