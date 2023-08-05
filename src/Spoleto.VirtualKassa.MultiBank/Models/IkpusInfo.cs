using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpusInfo : IMultiBankResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public List<IkpuData> Data { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Data)}: {String.Join(Environment.NewLine, Data.Select(x => x.ToString()))}";
    }
}
