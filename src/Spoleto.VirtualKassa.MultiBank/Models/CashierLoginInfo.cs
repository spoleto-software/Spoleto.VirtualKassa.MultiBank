using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierLoginInfo
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

        /// <summary>
        /// Из список кассиров
        /// </summary>
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        public override string ToString() => $"{nameof(Username)} = {Username}";
    }
}
