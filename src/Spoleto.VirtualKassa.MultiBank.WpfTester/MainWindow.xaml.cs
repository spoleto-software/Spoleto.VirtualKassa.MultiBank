using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Spoleto.Common.Helpers;
using Spoleto.VirtualKassa.MultiBank.Models;
using Spoleto.VirtualKassa.MultiBank.Providers;
using Spoleto.VirtualKassa.MultiBank.Tests;

namespace Spoleto.VirtualKassa.MultiBank.WpfTester
{
    /// <summary>
    /// The window for MultiBank API tests.
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ServiceProvider _serviceProvider;
        private readonly MultiBankOption _settings;

        public MainWindow()
        {
            InitializeComponent();

            // Set up the dependency injection container
            var services = new ServiceCollection();

            // Register your dependencies here.
            services.AddHttpClient();
            services.AddSingleton<IMultiBankProvider, MultiBankProvider>();

            // Build the service provider
            _serviceProvider = services.BuildServiceProvider();

            _settings = ConfigurationHelper.GetMultiBankSettings();
        }

        private async void GetDriverConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetDriverConfigurationAsync(_settings);

                GetDriverConfigurationResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetDriverConfigurationResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetFiscalModuleInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetFiscalModuleInfoAsync(_settings);

                GetFiscalModuleInfoResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetFiscalModuleInfoResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetCompanyDataButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetCompanyDataAsync(_settings);

                GetCompanyDataResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetCompanyDataResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetCashiersButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetCashiersAsync(_settings);

                GetCashiersResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetCashiersResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void SetCashRegisterSettingButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var settings = JsonHelper.FromJson<CashRegisterSettings>(SetCashRegisterSetting.Text);
                var result = await multiBankProvider.SetCashRegisterSettingsAsync(_settings, settings);

                SetCashRegisterSettingResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                SetCashRegisterSettingResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void CashierLoginButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var loginInfo = JsonHelper.FromJson<CashierLoginInfo>(CashierLoginInfo.Text);
                var result = await multiBankProvider.CashierLoginAsync(_settings, loginInfo);

                CashierLoginResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                CashierLoginResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void SellButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var saleSlip = JsonHelper.FromJson<SaleSlip>(SellInfo.Text);
                var result = await multiBankProvider.SellAsync(_settings, saleSlip);

                SellResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                SellResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var returnSlip = JsonHelper.FromJson<ReturnSlip>(ReturnInfo.Text);
                var result = await multiBankProvider.ReturnAsync(_settings, returnSlip);

                ReturnResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                ReturnResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetProfilesForAuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetProfilesForAuthorizationAsync(_settings, GetProfilesForAuthorizationInfo.Text);

                GetProfilesForAuthorizationResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetProfilesForAuthorizationResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetCashRegisterSettingButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetCashRegisterSettingsAsync(_settings);

                GetCashRegisterSettingResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetCashRegisterSettingResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetFiscalModuleStatusButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetFiscalModuleStatusAsync(_settings);

                GetFiscalModuleStatusResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetFiscalModuleStatusResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void GetNomenclaturesButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var result = await multiBankProvider.GetNomenclatureListAsync(_settings, false);

                GetNomenclaturesResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                GetNomenclaturesResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void SendSaleSlipByEmailButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var request = JsonHelper.FromJson<SendMailRequest>(SendSaleSlipByEmailInfo.Text);
                var result = await multiBankProvider.SendSaleSlipByEmailAsync(_settings, request);

                SendSaleSlipByEmailResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                SendSaleSlipByEmailResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void OpenShiftButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var request = JsonHelper.FromJson<OpenShiftRequest>(OpenShiftInfo.Text);
                await multiBankProvider.OpenShiftAsync(_settings, request);

                OpenShiftResult.Text = "OK!";// result.ToString();
            }
            catch (Exception ex)
            {
                OpenShiftResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void CloseShiftButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var request = JsonHelper.FromJson<CloseShiftRequest>(CloseShiftInfo.Text);
                await multiBankProvider.CloseShiftAsync(_settings, request);

                CloseShiftResult.Text = "OK!";// result.ToString();
            }
            catch (Exception ex)
            {
                CloseShiftResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void XReportButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var request = JsonHelper.FromJson<XReportRequest>(XReportInfo.Text);
                var result = await multiBankProvider.XReportAsync(_settings, request);

                XReportResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                XReportResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }

        private async void AdvanceSlipButton_Click(object sender, RoutedEventArgs e)
        {
            var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
            busyIndicator.IsBusy = true;

            try
            {
                var advanceSlip = JsonHelper.FromJson<AdvanceSlip>(AdvanceSlipInfo.Text);
                var result = await multiBankProvider.AdvanceSlipAsync(_settings, advanceSlip);

                AdvanceSlipResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                AdvanceSlipResult.Text = ex.Message;
            }
            finally
            {
                busyIndicator.IsBusy = false;
            }
        }
    }
}
