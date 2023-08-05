using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class MyIkpusInfoDataData
    {
        [JsonPropertyName("pkey")]
        public string Pkey { get; set; }

        [JsonPropertyName("tin")]
        public string Tin { get; set; }

        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("mxikFullName")]
        public string MxikFullName { get; set; }

        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        [JsonPropertyName("positionName")]
        public string PositionName { get; set; }

        [JsonPropertyName("subPositionName")]
        public string SubPositionName { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("attributeName")]
        public string AttributeName { get; set; }

        [JsonPropertyName("internationalCode")]
        public string InternationalCode { get; set; }

        [JsonPropertyName("unitCode")]
        public object UnitCode { get; set; }

        [JsonPropertyName("unitName")]
        public object UnitName { get; set; }

        [JsonPropertyName("unitValue")]
        public object UnitValue { get; set; }

        [JsonPropertyName("commonUnitCode")]
        public object CommonUnitCode { get; set; }

        [JsonPropertyName("commonUnitName")]
        public object CommonUnitName { get; set; }

        [JsonPropertyName("units")]
        public object Units { get; set; }

        [JsonPropertyName("packageNames")]
        public List<PackageName> PackageNames { get; set; }

        [JsonPropertyName("label")]
        public int Label { get; set; }

        [JsonPropertyName("usePackage")]
        public string UsePackage { get; set; }

        [JsonPropertyName("usePackage2")]
        public string UsePackage2 { get; set; }

        [JsonPropertyName("isActive")]
        public int IsActive { get; set; }

        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        public override string ToString() => $"{nameof(MxikFullName)} = {MxikFullName}, {nameof(InternationalCode)} = {InternationalCode}";
    }
}