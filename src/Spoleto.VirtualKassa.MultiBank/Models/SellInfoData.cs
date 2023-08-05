using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SellInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("receipt_sum")]
        public decimal ReceiptSum { get; set; }

        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcash")]
        public decimal ReceiptGnkReceivedCash { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcard")]
        public decimal ReceiptGnkReceivedCard { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        public string ReceiptGnkTime { get; set; }

        [JsonPropertyName("items")]
        public string Items { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("receipt_gnk_terminalid")]
        public string ReceiptGnkTerminalid { get; set; }

        [JsonPropertyName("receipt_gnk_qrcodeurl")]
        public string ReceiptGnkQrcodeurl { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        public int ReceiptGnkReceiptSeq { get; set; }

        [JsonPropertyName("receipt_gnk_fiscalsign")]
        public string ReceiptGnkFiscalsign { get; set; }

        [JsonPropertyName("receipt_gnk_appletversion")]
        public string ReceiptGnkAppletversion { get; set; }

        [JsonPropertyName("receipt_gnk_datetime")]
        public string ReceiptGnkDatetime { get; set; }

        [JsonPropertyName("app")]
        public string App { get; set; }

        [JsonPropertyName("demo")]
        public string Demo { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        public override string ToString() => $"{nameof(ModuleGnkId)} = {ModuleGnkId}, {nameof(ReceiptCashierName)} = {ReceiptCashierName}, {nameof(ReceiptSum)} = {ReceiptSum}, {nameof(ReceiptGnkReceiptSeq)} = {ReceiptGnkReceiptSeq}";
    }
}