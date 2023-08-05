using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class MyIkpusInfoData
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("dataData")]
        public List<MyIkpusInfoDataData> Data { get; set; }

        [JsonPropertyName("recordTotal")]
        public int RecordTotal { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Data)}: {String.Join(Environment.NewLine, Data.Select(x => x.ToString()))}";
    }
}