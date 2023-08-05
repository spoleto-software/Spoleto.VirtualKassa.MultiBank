using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipCriteria
    {
        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        [JsonPropertyName("start")]
        public int Start { get; set; } = 0;

        [JsonPropertyName("limit")]
        public int Limit { get; set; } = 15;
    }
}
