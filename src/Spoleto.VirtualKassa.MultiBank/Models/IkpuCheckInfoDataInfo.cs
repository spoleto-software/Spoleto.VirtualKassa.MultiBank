using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuCheckInfoDataInfo
    {
        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("internationalCode")]
        public object InternationalCode { get; set; }

        [JsonPropertyName("subPositionName")]
        public string SubPositionName { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("attributName")]
        public string AttributName { get; set; }

        [JsonPropertyName("nameUzCyrl")]
        public string NameUzCyrl { get; set; }

        [JsonPropertyName("nameUzLatin")]
        public string NameUzLatin { get; set; }

        [JsonPropertyName("nameRu")]
        public string NameRu { get; set; }

        [JsonPropertyName("unitCode")]
        public object UnitCode { get; set; }

        [JsonPropertyName("unitName")]
        public object UnitName { get; set; }

        [JsonPropertyName("commonUnitCode")]
        public object CommonUnitCode { get; set; }

        [JsonPropertyName("commonUnitName")]
        public object CommonUnitName { get; set; }

        [JsonPropertyName("label")]
        public int Label { get; set; }

        [JsonPropertyName("labelTNN")]
        public int LabelTNN { get; set; }

        [JsonPropertyName("usePackage")]
        public string UsePackage { get; set; }

        [JsonPropertyName("useLicense")]
        public string UseLicense { get; set; }

        [JsonPropertyName("isAllowedForOneSidedFactura")]
        public string IsAllowedForOneSidedFactura { get; set; }

        [JsonPropertyName("units")]
        public object Units { get; set; }

        [JsonPropertyName("packageNames")]
        public List<PackageName> PackageNames { get; set; }

        public override string ToString() => $"{nameof(NameRu)} = {NameRu}, {nameof(AttributName)} = {AttributName}";
    }
}