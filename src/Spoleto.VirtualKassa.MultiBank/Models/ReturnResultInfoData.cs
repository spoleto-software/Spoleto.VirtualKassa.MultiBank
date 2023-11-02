using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ReturnResultInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("RefundInfo")]
        public RefundInfo RefundInfo { get; set; }

        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        [JsonPropertyName("receipt_sum")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptSum { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcash")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptGnkReceivedCash { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcard")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptGnkReceivedCard { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkTime { get; set; }

        [JsonPropertyName("items")]
        public List<SlipResultItemInfo> Items { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("use_warehouse")]
        public bool UseWarehouse { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        public int ReceiptGnkReceiptSeq { get; set; }

        [JsonPropertyName("module_terminalid")]
        public string ModuleTerminalId { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("app")]
        public string App { get; set; }

        [JsonPropertyName("receipt_gnk_terminalid")]
        public string ReceiptGnkTerminalId { get; set; }

        [JsonPropertyName("receipt_gnk_qrcodeurl")]
        public string ReceiptGnkQrcodeUrl { get; set; }

        [JsonPropertyName("receipt_gnk_fiscalsign")]
        public string ReceiptGnkFiscalSign { get; set; }

        [JsonPropertyName("receipt_gnk_appletversion")]
        public string ReceiptGnkAppletVersion { get; set; }

        [JsonPropertyName("receipt_gnk_datetime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ReceiptGnkDatetime { get; set; }

        public override string ToString() => $"{nameof(ModuleGnkId)} = {ModuleGnkId}, {nameof(ReceiptCashierName)} = {ReceiptCashierName}, {nameof(ReceiptSum)} = {ReceiptSum}";
    }
}