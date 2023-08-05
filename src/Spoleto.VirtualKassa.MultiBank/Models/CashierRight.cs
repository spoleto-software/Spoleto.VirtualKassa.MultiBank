using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierRight
    {
        [JsonPropertyName("right_id")]
        public string RightId { get; set; }

        [JsonPropertyName("right_code")]
        public string RightCode { get; set; }

        [JsonPropertyName("right_name")]
        public string RightName { get; set; }

        [JsonPropertyName("right_of_role_value")]
        public string RightOfRoleValue { get; set; }

        public override string ToString() => $"{RightName}";
    }
}