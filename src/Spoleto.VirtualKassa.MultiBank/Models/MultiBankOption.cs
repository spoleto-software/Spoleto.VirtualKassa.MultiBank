namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Настройки провайдера Мульти-Банка.
    /// </summary>
    public class MultiBankOption
    {
        /// <summary>
        /// Адрес сервиса Мульти-Банка.
        /// </summary>
        public string ServiceUrl { get; init; }

        /// <summary>
        /// Логин пользователя.
        /// </summary>
        public string UserName { get; init; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; init; }

        /// <summary>
        /// Из списка кассиров
        /// </summary>
        public string ProfileId { get; init; }

        /// <summary>
        /// Из списка кассиров
        /// </summary>
        public string ProfileOfUserId { get; init; }

        public string VersionApi { get; init; } = "v1";

        public override string ToString() => $"{ServiceUrl} (Version = {VersionApi}).";
    }
}
