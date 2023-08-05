using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class XReportRequest
    {
        public XReportRequest(DateTime receiptGnkTime, string receiptCashierName)
        {
            ReceiptGnkTime = receiptGnkTime;
            ReceiptCashierName = receiptCashierName;
        }

        /// <summary>
        /// Номер из таблицы "Список номер операции"
        /// </summary>
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType => "7";

        /// <summary>
        /// Дата и время формирования X отчёта
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
