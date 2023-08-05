using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Расширенный поиск по тексту
    /// </summary>
    public class IkpuTextFilter
    {
        public IkpuTextFilter(string text)
        {
            Text = text;
        }

        [JsonPropertyName("lang")]
        public string Language { get; set; } = "ru";

        [JsonPropertyName("size")]
        public int Size { get; set; } = 200;

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;
    }
}
