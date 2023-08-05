using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipPayment
    {
        [JsonPropertyName("avansed")]
        public int Avansed { get; set; }

        [JsonPropertyName("credited")]
        public int Credited { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("paid")]
        public int Paid { get; set; }

        [JsonPropertyName("cashXOdd")]
        public int CashXOdd { get; set; }

        [JsonPropertyName("cardXOdd")]
        public int CardXOdd { get; set; }

        [JsonPropertyName("total_sum")]
        public int TotalSum { get; set; }

        [JsonPropertyName("cash")]
        public int Cash { get; set; }

        [JsonPropertyName("card")]
        public int Card { get; set; }

        [JsonPropertyName("OddSum")]
        public int OddSum { get; set; }

        [JsonPropertyName("cashier_name")]
        public string CashierName { get; set; }

        [JsonPropertyName("avanssequence")]
        public bool Avanssequence { get; set; }

        public override string ToString() => $"{nameof(Type)} = {Type}, {nameof(Paid)} = {Paid}, {nameof(TotalSum)} = {TotalSum}";
    }
}