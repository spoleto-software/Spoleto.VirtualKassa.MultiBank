using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CommissionInfo
    {
        [JsonPropertyName("PINFL")]
        public string PINFL { get; set; }

        [JsonPropertyName("TIN")]
        public string TIN { get; set; }

        public override string ToString() => $"{nameof(PINFL)} = {PINFL}, {nameof(TIN)} = {TIN}";
    }
}