using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Содержит информацию об отозванном чеке
    /// </summary>
    public class RefundInfo
    {
        /// <summary>
        /// Номер ФМ
        /// </summary>
        [JsonPropertyName("TerminalID")]
        public string TerminalID { get; set; }

        /// <summary>
        /// Номер отозванного чека
        /// </summary>
        [JsonPropertyName("ReceiptSeq")]
        public string ReceiptSeq { get; set; }

        /// <summary>
        /// Время продажи
        /// </summary>
        [JsonPropertyName("DateTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Фискальный признак
        /// </summary>
        [JsonPropertyName("FiscalSign")]
        public string FiscalSign { get; set; }

        public override string ToString() => $"{nameof(ReceiptSeq)} = {ReceiptSeq}, {nameof(DateTime)} = {DateTime}";
    }
}