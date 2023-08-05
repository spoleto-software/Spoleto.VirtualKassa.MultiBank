using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipsInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("receipt_sum")]
        public int ReceiptSum { get; set; }

        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcash")]
        public int ReceiptGnkReceivedCash { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcard")]
        public int ReceiptGnkReceivedCard { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkTime { get; set; }

        [JsonPropertyName("total_discount")]
        public int TotalDiscount { get; set; }

        [JsonPropertyName("total_nds")]
        public double TotalNds { get; set; }

        [JsonPropertyName("items")]
        public string Items { get; set; }

        [JsonPropertyName("payment")]
        public SlipPayment Payment { get; set; }

        [JsonPropertyName("contractor_name")]
        public string ContractorName { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("receipt_gnk_terminalid")]
        public string ReceiptGnkTerminalid { get; set; }

        [JsonPropertyName("receipt_gnk_qrcodeurl")]
        public string ReceiptGnkQrcodeurl { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        public string ReceiptGnkReceiptseq { get; set; }

        [JsonPropertyName("receipt_gnk_fiscalsign")]
        public string ReceiptGnkFiscalsign { get; set; }

        [JsonPropertyName("receipt_gnk_appletversion")]
        public string ReceiptGnkAppletversion { get; set; }

        [JsonPropertyName("receipt_gnk_datetime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkDatetime { get; set; }

        [JsonPropertyName("app")]
        public string App { get; set; }

        [JsonPropertyName("demo")]
        public string Demo { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("use_warehouse")]
        public bool? UseWarehouse { get; set; }
    }
}