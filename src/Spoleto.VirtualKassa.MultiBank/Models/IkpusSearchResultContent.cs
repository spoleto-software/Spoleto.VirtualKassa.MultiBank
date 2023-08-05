using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpusSearchResultContent
    {
        [JsonPropertyName("text")]
        public object Text { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        [JsonPropertyName("groupCode")]
        public string GroupCode { get; set; }

        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        [JsonPropertyName("classCode")]
        public string ClassCode { get; set; }

        [JsonPropertyName("positionName")]
        public string PositionName { get; set; }

        [JsonPropertyName("positionCode")]
        public string PositionCode { get; set; }

        [JsonPropertyName("subPositionName")]
        public string SubPositionName { get; set; }

        [JsonPropertyName("subPositionCode")]
        public string SubPositionCode { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("brandCode")]
        public string BrandCode { get; set; }

        [JsonPropertyName("mxikName")]
        public string MxikName { get; set; }

        [JsonPropertyName("attributeName")]
        public string AttributeName { get; set; }

        [JsonPropertyName("unitCode")]
        public object UnitCode { get; set; }

        [JsonPropertyName("unitName")]
        public object UnitName { get; set; }

        [JsonPropertyName("commonUnitCode")]
        public object CommonUnitCode { get; set; }

        [JsonPropertyName("commonUnitName")]
        public object CommonUnitName { get; set; }

        [JsonPropertyName("internationalCode")]
        public string InternationalCode { get; set; }

        [JsonPropertyName("label")]
        public int Label { get; set; }

        [JsonPropertyName("units")]
        public List<object> Units { get; set; }

        [JsonPropertyName("myProduct")]
        public int MyProduct { get; set; }

        [JsonPropertyName("packages")]
        public object Packages { get; set; }

        [JsonPropertyName("download")]
        public bool Download { get; set; }
    }
}