using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SaleSlip
    {
        /// <summary>
        /// Номер операции
        /// </summary>
        [Required]
        [JsonPropertyName("module_operation_type")]
        public virtual string ModuleOperationType => "3";

        /// <summary>
        /// ФИО Кассира
        /// </summary>
        [Required]
        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        /// <summary>
        /// Общая сумма
        /// </summary>
        [Required]
        [JsonPropertyName("receipt_sum")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptSum { get; set; }

        /// <summary>
        /// Оплата наличном
        /// </summary>
        [Required]
        [JsonPropertyName("receipt_gnk_receivedcash")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptGnkReceivedCash { get; set; }

        /// <summary>
        /// Оплата с картой
        /// </summary>
        [Required]
        [JsonPropertyName("receipt_gnk_receivedcard")]
        [JsonConverter(typeof(MultiplyDivide100Converter))]
        public decimal ReceiptGnkReceivedCard { get; set; }

        /// <summary>
        /// Дата и время открытие смены
        /// </summary>
        [Required]
        [JsonPropertyName("receipt_gnk_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkTime { get; set; }

        /// <summary>
        /// Массив товаров
        /// </summary>
        [Required]
        [JsonPropertyName("items")]
        public List<SlipItem> Items { get; set; }

        /// <summary>
        /// Локация
        /// </summary>
        [Required]
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        public override string ToString() => $"{nameof(ReceiptCashierName)} = {ReceiptCashierName}, {nameof(ReceiptSum)} = {ReceiptSum}";
    }
}
