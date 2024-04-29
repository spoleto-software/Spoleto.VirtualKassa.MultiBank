using Spoleto.VirtualKassa.MultiBank.IkpuUnitLoader.IkpuUnitLoader;

namespace Spoleto.VirtualKassa.MultiBank.WpfTester.IkpuUnitLoader
{
    public record IkpuUnitLoaderOptions
    {
        public int MaxDegreeOfParallelism { get; set; }

        public string IdColumnName { get; set; }

        public string CodeColumnName { get; set; }

        public string OriginIkpuTableName { get; set; }

        public string TargetIkpuUnitTableName { get; set; }

        public string ConnectrionString { get; set; }

        public string ServiceUrl { get; set; }

        public string BearerToken { get; set; }

        public ProxyInfo? ProxyInfo { get; set; }
    }
}
