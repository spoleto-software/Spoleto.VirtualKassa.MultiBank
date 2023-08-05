using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ProfileToAttach
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }
    }
}
