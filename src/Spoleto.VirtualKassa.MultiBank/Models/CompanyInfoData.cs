using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CompanyInfoData
    {
        [JsonPropertyName("module_id")]
        public string ModuleId { get; set; }

        [JsonPropertyName("module_name")]
        public string ModuleName { get; set; }

        [JsonPropertyName("module_type")]
        public string ModuleType { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("module_gnk_terminalid")]
        public string ModuleGnkTerminalid { get; set; }

        [JsonPropertyName("module_status_now")]
        public int ModuleStatusNow { get; set; }

        [JsonPropertyName("module_data")]
        public object ModuleData { get; set; }

        [JsonPropertyName("module_service_paid_to")]
        public object ModuleServicePaidTo { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("created_by")]
        public object CreatedBy { get; set; }

        [JsonPropertyName("cashbox_type")]
        public int CashboxType { get; set; }

        [JsonPropertyName("module_terminalid")]
        public string ModuleTerminalid { get; set; }

        [JsonPropertyName("local_tsc_id")]
        public string LocalTscId { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("tradepoint_to_module_id")]
        public string TradepointToModuleId { get; set; }

        [JsonPropertyName("tradepoint_id")]
        public string TradepointId { get; set; }

        [JsonPropertyName("tradepoint_to_module_start")]
        public string TradepointToModuleStart { get; set; }

        [JsonPropertyName("tradepoint_to_module_stop")]
        public object TradepointToModuleStop { get; set; }

        [JsonPropertyName("contragent_id")]
        public string ContragentId { get; set; }

        [JsonPropertyName("tradepoint_name")]
        public string TradepointName { get; set; }

        [JsonPropertyName("tradepoint_address")]
        public string TradepointAddress { get; set; }

        [JsonPropertyName("tradepoint_region")]
        public object TradepointRegion { get; set; }

        [JsonPropertyName("tradepoint_cadaster")]
        public object TradepointCadaster { get; set; }

        [JsonPropertyName("tradepoint_phone")]
        public string TradepointPhone { get; set; }

        [JsonPropertyName("tradepoint_contact")]
        public object TradepointContact { get; set; }

        [JsonPropertyName("tradepoint_coordinates")]
        public string TradepointCoordinates { get; set; }

        [JsonPropertyName("tradepoint_sphere")]
        public string TradepointSphere { get; set; }

        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        [JsonPropertyName("company_tin")]
        public string CompanyTin { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("company_data")]
        public string CompanyData { get; set; }

        public override string ToString() => $"{nameof(ModuleGnkId)} = {ModuleGnkId}, {nameof(Name)} = {Name}";
    }
}