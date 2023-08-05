﻿using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleInfo : IMultiBankResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public FiscalModuleInfoData Data { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Data)} = {Data}";
    }
}
