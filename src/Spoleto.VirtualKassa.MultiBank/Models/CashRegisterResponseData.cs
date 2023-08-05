using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashRegisterResponseData
    {
        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("printer_name")]
        public string PrinterName { get; set; }

        [JsonPropertyName("paper_size")]
        public string PaperSize { get; set; }

        [JsonPropertyName("keyboard")]
        public string Keyboard { get; set; }

        [JsonPropertyName("show_check")]
        public string ShowCheck { get; set; }

        [JsonPropertyName("last_offline_time")]
        public string LastOfflineTime { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("codepage")]
        public string Codepage { get; set; }

        [JsonPropertyName("force_to_print")]
        public string ForceToPrint { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("current_profile")]
        public string CurrentProfile { get; set; }

        [JsonPropertyName("with_login")]
        public string WithLogin { get; set; }

        [JsonPropertyName("enter")]
        public string Enter { get; set; }

        [JsonPropertyName("demo")]
        public string Demo { get; set; }

        [JsonPropertyName("shift")]
        public object Shift { get; set; }

        [JsonPropertyName("printQRWithPng")]
        public string PrintQRWithPng { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("showClient")]
        public string ShowClient { get; set; }

        [JsonPropertyName("parent_product_id")]
        public object ParentProductId { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("receipt_image")]
        public string ReceiptImage { get; set; }

        public override string ToString() => $"{nameof(ModuleGnkId)} = {ModuleGnkId}, {nameof(PrinterName)} = {PrinterName}, {nameof(Token)} = {Token}";
    }
}