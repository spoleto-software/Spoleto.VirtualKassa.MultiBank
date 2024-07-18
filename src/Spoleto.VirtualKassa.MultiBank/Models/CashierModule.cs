using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierModule
    {
        [JsonPropertyName("cashbox_of_profile_of_user_id")]
        public string CashboxOfProfileOfUserId { get; set; }

        [JsonPropertyName("profile_of_user_uuid")]
        public string ProfileOfUserUuid { get; set; }

        [JsonPropertyName("module_id")]
        public string ModuleId { get; set; }
    }
}