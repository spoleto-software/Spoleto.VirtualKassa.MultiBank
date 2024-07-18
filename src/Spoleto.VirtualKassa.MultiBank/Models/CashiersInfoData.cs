using System.Data;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashiersInfoData
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("profile_of_user_uuid")]
        public string ProfileOfUserUuid { get; set; }

        [JsonPropertyName("profile_uuid")]
        public string ProfileUuid { get; set; }

        [JsonPropertyName("person_id")]
        public string PersonId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("user_first_name")]
        public string UserFirstName { get; set; }

        [JsonPropertyName("user_last_name")]
        public string UserLastName { get; set; }

        [JsonPropertyName("user_middle_name")]
        public string UserMiddleName { get; set; }

        [JsonPropertyName("roles")]
        public List<CashierRole> Roles { get; set; }

        [JsonPropertyName("modules")]
        public List<CashierModule> Modules { get; set; }
       
        public override string ToString() => $"{nameof(Login)} = {Login}, {nameof(Roles)}: {String.Join(Environment.NewLine, Roles.Select(x => x.ToString()))}";
    }
}