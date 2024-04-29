namespace Spoleto.VirtualKassa.MultiBank.IkpuUnitLoader.IkpuUnitLoader
{
    public class ProxyInfo
    {
        public string Url { get; set; }

        public ProxyCredentials? Credentials { get; set; }

        public override string ToString() => Url;
    }
}
