using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CreditSlipPayment
    {
        [JsonPropertyName("avansed")]
        public decimal Avansed { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("paid")]
        public decimal Paid { get; set; }

        [JsonPropertyName("cashXOdd")]
        public decimal CashXOdd { get; set; }

        [JsonPropertyName("cardXOdd")]
        public decimal CardXOdd { get; set; }

        [JsonPropertyName("total_sum")]
        public decimal TotalSum { get; set; }

        [JsonPropertyName("cash")]
        public decimal Cash { get; set; }

        [JsonPropertyName("card")]
        public decimal Card { get; set; }

        [JsonPropertyName("OddSum")]
        public decimal OddSum { get; set; }

        [JsonPropertyName("cashier_name")]
        public string CashierName { get; set; }

        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; } = "8"; //todo: какой тут тип? Всегда одинаковый или может быть разным?

        public override string ToString() => $"{nameof(Type)} = {Type}, {nameof(Paid)} = {Paid}, {nameof(TotalSum)} = {TotalSum}";
    }
}