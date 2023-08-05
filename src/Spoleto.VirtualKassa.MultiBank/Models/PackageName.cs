using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class PackageName
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("nameUz")]
        public string NameUz { get; set; }

        [JsonPropertyName("packageType")]
        public string PackageType { get; set; }

        [JsonPropertyName("nameRu")]
        public string NameRu { get; set; }

        [JsonPropertyName("nameLat")]
        public string NameLat { get; set; }

        public override string ToString() => $"{nameof(NameRu)} = {NameRu}, {nameof(PackageType)} = {PackageType}";
    }
}