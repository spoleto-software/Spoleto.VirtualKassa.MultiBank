using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ReturnSlipInfo
    {
        [JsonPropertyName("TerminalID")]
        public string TerminalID { get; set; }

        [JsonPropertyName("ReceiptSeq")]
        public string ReceiptSeq { get; set; }

        [JsonPropertyName("DateTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateTime { get; set; }

        [JsonPropertyName("FiscalSign")]
        public string FiscalSign { get; set; }

        public override string ToString() => $"{nameof(ReceiptSeq)} = {ReceiptSeq}, {nameof(DateTime)} = {DateTime}";
    }
}