using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CloseShiftRequest
    {
        public CloseShiftRequest(DateTime receiptGnkTime)
        {
            ReceiptGnkTime = receiptGnkTime;
        }

        /// <summary>
        /// Номер из таблицы "Список номер операции"
        /// </summary>
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType => "2";

        /// <summary>
        /// Дата и время закрытия смены
        /// </summary>
        [JsonPropertyName("receipt_gnk_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkTime { get; set; }

        /// <summary>
        /// ФИО Кассира
        /// </summary>
        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }
    }
}
