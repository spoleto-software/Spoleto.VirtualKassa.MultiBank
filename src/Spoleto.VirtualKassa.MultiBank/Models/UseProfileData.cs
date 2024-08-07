﻿using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class UseProfileData
    {
        [JsonPropertyName("profile_uuid")]
        public string ProfileId { get; set; }

        public override string ToString() => $"{nameof(ProfileId)} = {ProfileId}";
    }
}