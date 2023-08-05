using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Sender
    {
        [JsonPropertyName("LiveAddress")]
        public string LiveAddress { get; set; }

        [JsonPropertyName("LastSendReceiveDuration")]
        public string LastSendReceiveDuration { get; set; }

        [JsonPropertyName("LastOnlineTime")]
        public DateTime? LastOnlineTime { get; set; }

        [JsonPropertyName("TotalFilesSent")]
        public Dictionary<string, int> TotalFilesSent { get; set; }

        [JsonPropertyName("FullReceiptFilesSent")]
        public Dictionary<string, int> FullReceiptFilesSent { get; set; }

        [JsonPropertyName("ReceiptFilesSent")]
        public Dictionary<string, int> ReceiptFilesSent { get; set; }

        [JsonPropertyName("AdvanceReceiptFilesSent")]
        public Dictionary<string, int> AdvanceReceiptFilesSent { get; set; }

        [JsonPropertyName("CreditReceiptFilesSent")]
        public Dictionary<string, int> CreditReceiptFilesSent { get; set; }

        [JsonPropertyName("EncodedFullReceiptBodyFilesSent")]
        public Dictionary<string, int> EncodedFullReceiptBodyFilesSent { get; set; }

        [JsonPropertyName("ZReportFilesSent")]
        public Dictionary<string, int> ZReportFilesSent { get; set; }

        [JsonPropertyName("TotalAckFilesReceived")]
        public Dictionary<string, int> TotalAckFilesReceived { get; set; }

        public override string ToString() => $"{nameof(LiveAddress)} = {LiveAddress}, {nameof(LastOnlineTime)} = {LastOnlineTime}";
    }
}