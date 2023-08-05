using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Sort
    {
        [JsonPropertyName("unsorted")]
        public bool Unsorted { get; set; }

        [JsonPropertyName("sorted")]
        public bool Sorted { get; set; }

        [JsonPropertyName("empty")]
        public bool Empty { get; set; }
    }
}