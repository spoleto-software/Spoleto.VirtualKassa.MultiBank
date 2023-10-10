﻿using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SellResultInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        [JsonPropertyName("receipt_sum")]
        public int ReceiptSum { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcash")]
        public int ReceiptGnkReceivedcash { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcard")]
        public int ReceiptGnkReceivedcard { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        public string ReceiptGnkTime { get; set; }

        [JsonConverter(typeof(SlipResultItemInfoConverter))]
        [JsonPropertyName("items")]
        public List<SlipResultItemInfo> Items { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("use_warehouse")]
        public bool UseWarehouse { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        public int ReceiptGnkReceiptseq { get; set; }

        [JsonPropertyName("module_terminalid")]
        public string ModuleTerminalid { get; set; }

        [JsonPropertyName("app")]
        public string App { get; set; }

        [JsonPropertyName("demo")]
        public string Demo { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        public override string ToString() => $"{nameof(ModuleGnkId)} = {ModuleGnkId}, {nameof(ReceiptCashierName)} = {ReceiptCashierName}, {nameof(ReceiptSum)} = {ReceiptSum}";
    }
}