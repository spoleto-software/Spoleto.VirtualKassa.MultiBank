﻿using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuChangeHistory : IMultiBankResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public IkpuChangeHistoryData Data { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        public override string ToString() => $"{nameof(Success)} = {Success}, {nameof(Data)} = {Data}";
    }
}
