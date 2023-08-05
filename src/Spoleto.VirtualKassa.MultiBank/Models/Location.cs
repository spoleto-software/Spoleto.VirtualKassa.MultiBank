using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Location
    {
        [Required]
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [Required]
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        public override string ToString() => $"{nameof(Latitude)} = {Latitude}, {nameof(Longitude)} = {Longitude}";
    }
}
