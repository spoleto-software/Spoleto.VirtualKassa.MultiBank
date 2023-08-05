using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Поиск по ИКПУ
    /// </summary>
    public class IkpuCodeFilter
    {
        public IkpuCodeFilter(string mxikCode)
        {
            MxikCode = mxikCode;
        }

        [JsonPropertyName("lang")]
        public string Language { get; set; } = "ru";

        [JsonPropertyName("size")]
        public int Size { get; set; } = 200;

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;
    }
}
