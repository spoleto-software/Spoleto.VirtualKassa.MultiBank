using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Настройки кассы
    /// </summary>
    public class CashRegisterSettings
    {
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        public CashRegisterSettings(string moduleGnkId, string printerName, bool demo)
        {
            ModuleGnkId = moduleGnkId;
            PrinterName = printerName;
            Demo = demo;
        }

        /// <summary>
        /// Номер фискального модуля
        /// </summary>
        /// <remarks>
        /// Например, UZ777777777777
        /// </remarks>
        [Required]
        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        /// <summary>
        /// Название принтера для печати
        /// </summary>
        /// <remarks>
        /// Например, SAM4S GIANT-100
        /// </remarks>
        [Required]
        [JsonPropertyName("printer_name")]
        public string PrinterName { get; set; }

        /// <summary>
        /// Режим работы кассы ("false" - для фискальных касс , "true" - для демо касс).
        /// </summary>
        [Required]
        [JsonPropertyName("demo")]
        public bool Demo { get; set; }

        /// <summary>
        /// Размер бумаги.
        /// </summary>
        /// <remarks>
        /// Доступные значения - "57", "80".<br/>
        /// По умолчанию: 80.
        /// </remarks>
        [JsonPropertyName("paper_size")]
        public string? PaperSize { get; set; }

        /// <summary>
        /// Авто печать чека.
        /// </summary>
        /// <remarks>
        /// По умолчанию: true.
        /// </remarks>
        [JsonPropertyName("force_to_print")]
        public bool? ForceToPrint { get; set; }

        /// <summary>
        /// Печать QR-кода в виде изображения.
        /// </summary>
        /// <remarks>
        /// По умолчанию: false.
        /// </remarks>
        [JsonPropertyName("printQRWithPng")]
        public bool? PrintQRWithPng { get; set; }

        /// <summary>
        /// Показывать покупателя в чеке.
        /// </summary>
        /// <remarks>
        /// По умолчанию: false.
        /// </remarks>
        [JsonPropertyName("showClient")]
        public bool? ShowClient { get; set; }

        /// <summary>
        /// Язык приложения.
        /// </summary>
        /// <remarks>
        /// Доступные значения - "ру", "uz", "ўз".<br/>
        /// По умолчанию: "ру".
        /// </remarks>
        [JsonPropertyName("lang")]
        public string? Language { get; set; }

        /// <summary>
        /// Тип приложения (Значение "prod" для режима работы в продакшн, "staging" для режима разработчика)
        /// </summary>
        /// <remarks>
        /// По умолчанию: prod.
        /// </remarks>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Кодировка принтера.
        /// </summary>
        /// <remarks>
        /// По умолчанию: cp866.
        /// </remarks>
        [JsonPropertyName("codepage")]
        public string? CodePage { get; set; }
    }
}
