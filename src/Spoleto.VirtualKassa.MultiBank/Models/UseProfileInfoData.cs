using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class UseProfileInfoData
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("contragent_id")]
        public string ContragentId { get; set; }

        [JsonPropertyName("profile_root")]
        public bool? ProfileRoot { get; set; }

        [JsonPropertyName("profile_created_at")]
        public string ProfileCreatedAt { get; set; }

        [JsonPropertyName("profile_updated_at")]
        public string ProfileUpdatedAt { get; set; }

        [JsonPropertyName("profile_accepted")]
        public bool ProfileAccepted { get; set; }

        [JsonPropertyName("profile_accept_code")]
        public string ProfileAcceptCode { get; set; }

        [JsonPropertyName("profile_verified")]
        public bool ProfileVerified { get; set; }

        [JsonPropertyName("contragent_type")]
        public int ContragentType { get; set; }

        [JsonPropertyName("contragent_data")]
        public object ContragentData { get; set; }

        [JsonPropertyName("contragent_tin")]
        public string ContragentTin { get; set; }

        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        [JsonPropertyName("company_tin")]
        public string CompanyTin { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("company_data")]
        public string CompanyData { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        public override string ToString() => $"{nameof(Name)} = {Name}, {nameof(ProfileId)} = {ProfileId}";
    }
}