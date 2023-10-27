using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Headers
    {
        [JsonPropertyName("Accept")]
        public string Accept { get; set; }

        [JsonPropertyName("Content-Type")]
        public string ContentType { get; set; }

        [JsonPropertyName("User-Agent")]
        public string UserAgent { get; set; }

        [JsonPropertyName("Content-Length")]
        public int ContentLength { get; set; }
    }
}