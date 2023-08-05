using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierLoginResponse : IMultiBankResponse
    {
        [JsonPropertyName("token")]
        public TokenInfo Token { get; set; }

        [JsonPropertyName("useProfile")]
        public UseProfile UseProfile { get; set; }

        [JsonIgnore]
        public bool Success
        {
            get => UseProfile.Success;
            set { }
        }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(UseProfile)} = {UseProfile}";
    }
}
