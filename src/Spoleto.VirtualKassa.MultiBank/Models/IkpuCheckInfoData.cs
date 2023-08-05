using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuCheckInfoData
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("reason")]
        public object Reason { get; set; }

        [JsonPropertyName("dataData")]
        public List<IkpuCheckInfoDataData> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Data)}: {String.Join(Environment.NewLine, Data.Select(x => x.ToString()))}";
    }
}