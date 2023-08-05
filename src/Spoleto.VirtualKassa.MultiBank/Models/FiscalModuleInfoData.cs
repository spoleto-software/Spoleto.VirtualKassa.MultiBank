using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleInfoData
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("result")]
        public FiscalModuleInfoDataResult Result { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        public override string ToString() => $"{nameof(Id)} = {Id}, {nameof(Result)} = {Result}";
    }
}