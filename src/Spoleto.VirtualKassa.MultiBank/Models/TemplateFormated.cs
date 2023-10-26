using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class TemplateFormated
    {
        [JsonPropertyName("value")]
        public object Value { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("order")]
        public double Order { get; set; }
    }
}