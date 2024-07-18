using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Only userName and password (without profile id).
    /// </summary>
    public class CashierExternalLoginInfo
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        public override string ToString() => $"{nameof(Username)} = {Username}";
    }
}
