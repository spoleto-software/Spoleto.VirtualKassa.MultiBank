using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuChangeHistoryData
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("dataData")]
        public IkpuChangeHistoryDataData DataData { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; }

        public override string ToString() => $"{DataData}";
    }
}