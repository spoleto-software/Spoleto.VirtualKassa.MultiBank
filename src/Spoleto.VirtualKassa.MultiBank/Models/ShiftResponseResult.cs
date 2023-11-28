using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ShiftResponseResult
    {
        [JsonPropertyName("AppletVersion")]
        public string AppletVersion { get; set; }

        public override string ToString() => AppletVersion;
    }
}