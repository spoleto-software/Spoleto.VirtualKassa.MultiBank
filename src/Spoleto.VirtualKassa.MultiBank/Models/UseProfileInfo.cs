using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class UseProfileInfo : IMultiBankResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public List<UseProfileInfoData> Data { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        public override string ToString() => $"{String.Join(Environment.NewLine, Data.Select(x => x.ToString()))}";
    }
}
