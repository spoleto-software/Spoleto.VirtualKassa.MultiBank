using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleStatusDataResult
    {
        [JsonPropertyName("StartTime")]
        public string StartTime { get; set; }

        [JsonPropertyName("Sender")]
        public Sender Sender { get; set; }

        [JsonPropertyName("DB")]
        public FiscalModuleStatusDB DB { get; set; }

        public override string ToString() => $"{nameof(StartTime)} = {StartTime}, {nameof(Sender)}: {Sender}, {nameof(DB)}: {DB}";
    }
}