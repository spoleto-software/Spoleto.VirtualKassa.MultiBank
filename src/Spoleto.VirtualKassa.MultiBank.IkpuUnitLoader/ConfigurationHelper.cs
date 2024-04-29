using Microsoft.Extensions.Configuration;
using Spoleto.VirtualKassa.MultiBank.WpfTester.IkpuUnitLoader;

namespace Spoleto.VirtualKassa.MultiBank.IkpuUnitLoader
{
    public static class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddUserSecrets("ac9436b5-16e3-4fdb-acce-226bb4ad441f")
               .Build();
        }

        public static IkpuUnitLoaderOptions GetLoaderOptions()
        {
            var options = _config.GetSection(nameof(IkpuUnitLoaderOptions)).Get<IkpuUnitLoaderOptions>();

            return options;
        }
    }
}
