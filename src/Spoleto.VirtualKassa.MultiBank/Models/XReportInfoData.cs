using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class XReportInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("module_gnk_terminalid")]
        public string ModuleGnkTerminalId { get; set; }

        [JsonPropertyName("module_operation_shift_id")]
        public object ModuleOperationShiftId { get; set; }

        [JsonPropertyName("receipt_gnk_appletversion")]
        public string ReceiptGnkAppletversion { get; set; }

        [JsonPropertyName("closetime")]
        public string CloseTime { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        public string ReceiptGnkTime { get; set; }

        [JsonPropertyName("lastoperation")]
        public int Lastoperation { get; set; }

        [JsonPropertyName("offline")]
        public string Offline { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        [JsonConverter(typeof(IntAsStringConverter))]
        public int ReceiptGnkReceiptseq { get; set; }

        [JsonPropertyName("module_operation_sum_cash")]
        public int ModuleOperationSumCash { get; set; }

        [JsonPropertyName("module_operation_sum_card")]
        public decimal ModuleOperationSumCard { get; set; }

        [JsonPropertyName("module_operation_sum_cash_ret")]
        public int ModuleOperationSumCashRet { get; set; }

        [JsonPropertyName("module_operation_sum_sales")]
        public decimal ModuleOperationSumSales { get; set; }

        [JsonPropertyName("module_operation_sum_return")]
        public int ModuleOperationSumReturn { get; set; }

        [JsonPropertyName("sale_count")]
        public int SaleCount { get; set; }

        [JsonPropertyName("refund_count")]
        public int RefundCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("proceeds_cash")]
        public decimal ProceedsCash { get; set; }

        [JsonPropertyName("proceeds_card")]
        public decimal ProceedsCard { get; set; }

        [JsonPropertyName("vat")]
        public decimal Vat { get; set; }

        [JsonPropertyName("vat_ret")]
        public decimal VatRet { get; set; }

        [JsonPropertyName("proceeds")]
        public decimal Proceeds { get; set; }

        public override string ToString() => $"{nameof(SaleCount)} = {SaleCount}, {nameof(RefundCount)} = {RefundCount}";
    }
}