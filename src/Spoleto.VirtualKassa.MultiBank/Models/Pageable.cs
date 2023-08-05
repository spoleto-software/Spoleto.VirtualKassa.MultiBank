using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Pageable
    {
        [JsonPropertyName("sort")]
        public Sort Sort { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("unpaged")]
        public bool Unpaged { get; set; }

        [JsonPropertyName("paged")]
        public bool Paged { get; set; }
    }
}