using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ShiftResponseData
    {
        #region Successful response
        [JsonPropertyName("jsonrpc")]
        public string? Jsonrpc { get; set; }

        [JsonPropertyName("result")]
        public ShiftResponseResult? Result { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
        #endregion

        #region Unsuccessful response

        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public string? Data { get; set; }
        #endregion

        public override string ToString() 
            => Code is not null
            ? $"{nameof(Code)} = {Code}, {nameof(Message)} = {Message}"
            : $"{nameof(Id)} = {Id}, {nameof(Result)} = {Result}";
    }
}