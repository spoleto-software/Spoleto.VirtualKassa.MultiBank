using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// Дополнительный авансовый чек
    /// </summary>
    public class AdditionalAdvanceSlip: AdvanceSlip
    {
        /// <summary>
        /// Номер операции
        /// </summary>
        [Required]
        [JsonPropertyName("module_operation_type")]
        public sealed override string ModuleOperationType => "9";
    }
}