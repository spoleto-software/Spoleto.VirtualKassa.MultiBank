using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Поиск по штрих-коду
    /// </summary>
    public class IkpuGtinFilter
    {
        public IkpuGtinFilter(string gtin)
        {
            Gtin = gtin;
        }

        [JsonPropertyName("lang")]
        public string Language { get; set; } = "ru";

        [JsonPropertyName("size")]
        public int Size { get; set; } = 200;

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("gtin")]
        public string Gtin { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;
    }
}
