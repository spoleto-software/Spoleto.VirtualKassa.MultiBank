using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleInfoDataResult
    {
        [JsonPropertyName("TerminalID")]
        public string TerminalID { get; set; }

        [JsonPropertyName("AppletVersion")]
        public string AppletVersion { get; set; }

        [JsonPropertyName("CurrentReceiptSeq")]
        public string CurrentReceiptSeq { get; set; }

        [JsonPropertyName("CurrentTime")]
        public string CurrentTime { get; set; }

        [JsonPropertyName("ReceiptCount")]
        public int ReceiptCount { get; set; }

        [JsonPropertyName("ReceiptMaxCount")]
        public int ReceiptMaxCount { get; set; }

        [JsonPropertyName("ZReportCount")]
        public int ZReportCount { get; set; }

        [JsonPropertyName("ZReportMaxCount")]
        public int ZReportMaxCount { get; set; }

        [JsonPropertyName("AvailablePersistentMemory")]
        public int AvailablePersistentMemory { get; set; }

        [JsonPropertyName("AvailableResetMemory")]
        public int AvailableResetMemory { get; set; }

        [JsonPropertyName("AvailableDeselectMemory")]
        public int AvailableDeselectMemory { get; set; }

        public override string ToString() => $"{nameof(TerminalID)} = {TerminalID}, {nameof(AppletVersion)} = {AppletVersion}";
    }
}