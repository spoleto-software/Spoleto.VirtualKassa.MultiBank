﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class ReturnSlip : SaleSlip
    {
        /// <summary>
        /// Номер операции
        /// </summary>
        [Required]
        [JsonPropertyName("module_operation_type")]
        public override string ModuleOperationType => "4";

        /// <summary>
        /// Информация об отозванном чеке
        /// </summary>
        [Required]
        [JsonPropertyName("RefundInfo")]
        public ReturnSlipInfo ReturnSlipInfo { get; set; }

        public override string ToString() => $"{nameof(ReturnSlipInfo)} = {ReturnSlipInfo}, {base.ToString()}";
    }
}
