using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CreditSlip : SaleSlip
    {
        /// <summary>
        /// Номер операции
        /// </summary>
        [Required]
        [JsonPropertyName("module_operation_type")]
        public sealed override string ModuleOperationType => "9";

        [JsonPropertyName("total_nds")]
        public decimal TotalNds { get; set; }

        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("_cashXOdd")]
        public decimal CashXOdd { get; set; }

        [JsonPropertyName("_cardXOdd")]
        public decimal CardXOdd { get; set; }

        [JsonPropertyName("module_operation_shift_id")]
        public string ModuleOperationShiftId { get; set; }

        [JsonPropertyName("module_operation_datetime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ModuleOperationDateTime { get; set; }

        [JsonPropertyName("receipt_gnk_datetime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkDateTime { get; set; }

        [JsonPropertyName("module_gnk_terminalid")]
        public string ModuleGnkTerminalid { get; set; }

        [JsonPropertyName("module_operation_sum_sales")]
        public decimal ModuleOperationSumSales { get; set; }

        [JsonPropertyName("module_operation_sum_cash")]
        public decimal ModuleOperationSumCash { get; set; }

        [JsonPropertyName("module_operation_sum_card")]
        public decimal ModuleOperationSumCard { get; set; }

        [JsonPropertyName("module_operation_sum_odd")]
        public decimal ModuleOperationSumOdd { get; set; }

        [JsonPropertyName("module_operation_sum_return")]
        public string ModuleOperationSumReturn { get; set; }

        [JsonPropertyName("module_operation_sum_output")]
        public string ModuleOperationSumOutput { get; set; }

        [JsonPropertyName("module_operation_sum_refill")]
        public string ModuleOperationSumRefill { get; set; }

        [JsonPropertyName("payment")]
        public CreditSlipPayment Payment { get; set; }

    }
}
