using System.Data;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashiersInfoData
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("contragent_id")]
        public string ContragentId { get; set; }

        [JsonPropertyName("person_id")]
        public object PersonId { get; set; }

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

        public override string ToString() => $"{nameof(Login)} = {Login}, {nameof(Roles)}: {String.Join(Environment.NewLine, Roles.Select(x => x.ToString()))}";
    }
}