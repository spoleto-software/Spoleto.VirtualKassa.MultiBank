using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class AttachProfileResponseData
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        public override string ToString() => ProfileId;
    }
}