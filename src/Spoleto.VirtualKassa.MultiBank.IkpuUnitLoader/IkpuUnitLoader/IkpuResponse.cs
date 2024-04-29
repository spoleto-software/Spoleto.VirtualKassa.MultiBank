using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.WpfTester.IkpuUnitLoader
{
    internal class IkpuResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("data")]
        public List<PackageName> Data { get; set; }
    }
}
