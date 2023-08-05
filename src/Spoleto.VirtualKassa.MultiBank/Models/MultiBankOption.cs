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

        public override string ToString() => ServiceUrl;
    }
}
