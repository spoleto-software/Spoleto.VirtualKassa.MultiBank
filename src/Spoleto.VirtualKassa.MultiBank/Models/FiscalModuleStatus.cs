using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleStatus : IMultiBankResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        [JsonConverter(typeof(StringAsIntStringConverter))]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public FiscalModuleStatusData Data { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stack")]
        public string Stack { get; set; }

        [JsonPropertyName("config")]
        public Config Config { get; set; }

        //[JsonPropertyName("status")]
        //public object Status { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Name)} = {Name}, {nameof(Data)}: {Data}";
    }
}
