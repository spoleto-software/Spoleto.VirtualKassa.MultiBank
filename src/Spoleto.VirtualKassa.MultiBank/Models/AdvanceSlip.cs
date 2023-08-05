using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Авансовый чек
    /// </summary>
    public class AdvanceSlip : SaleSlip
    {
        /// <summary>
        /// Номер операции
        /// </summary>
        [Required]
        [JsonPropertyName("module_operation_type")]
        public override string ModuleOperationType => "8";

        [JsonPropertyName("module_gnk_terminalid")]
        public string ModuleGnkTerminalId { get; set; }
    }
}