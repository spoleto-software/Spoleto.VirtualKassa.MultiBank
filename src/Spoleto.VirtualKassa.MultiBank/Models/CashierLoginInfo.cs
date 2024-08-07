﻿using System.Text.Json.Serialization;

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
        /// Из списка кассиров
        /// </summary>
        [JsonPropertyName("profile_uuid")]
        public string ProfileId { get; set; }

        /// <summary>
        /// Из списка кассиров
        /// </summary>
        [JsonPropertyName("profile_of_user_uuid")]
        public string ProfileOfUserId { get; set; }

        public override string ToString() => $"{nameof(Username)} = {Username}";
    }
}
