using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SendMailRequest
    {
        [JsonPropertyName("mail")]
        public string Mail { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }
    }
}
