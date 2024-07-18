using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class TokenInfoData
    {
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("profile_uuid")]
        public string ProfileUuid { get; set; }

        public override string ToString() => $"{nameof(TokenType)} = {TokenType}, {nameof(AccessToken)} = {AccessToken}";
    }
}