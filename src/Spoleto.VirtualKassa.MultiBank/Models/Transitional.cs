using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Transitional
    {
        [JsonPropertyName("silentJSONParsing")]
        public bool SilentJSONParsing { get; set; }

        [JsonPropertyName("forcedJSONParsing")]
        public bool ForcedJSONParsing { get; set; }

        [JsonPropertyName("clarifyTimeoutError")]
        public bool ClarifyTimeoutError { get; set; }
    }
}