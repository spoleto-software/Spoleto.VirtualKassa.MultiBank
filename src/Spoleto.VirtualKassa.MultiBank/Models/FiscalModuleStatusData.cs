using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleStatusData
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("result")]
        public FiscalModuleStatusDataResult Result { get; set; }

        public override string ToString() => $"{nameof(Id)} = {Id}, {nameof(Result)}: {Result}";
    }
}
