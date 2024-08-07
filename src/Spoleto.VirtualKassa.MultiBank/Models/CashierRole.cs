﻿using System.Data;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierRole
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("guard_name")]
        public string GuardName { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("admin")]
        public bool Admin { get; set; }

        [JsonPropertyName("sort")]
        public int Sort { get; set; }

        [JsonPropertyName("module_name")]
        public string ModuleName { get; set; }

        [JsonPropertyName("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonPropertyName("permissions")]
        public List<CashierPermission> Permissions { get; set; }

        public override string ToString() => $"{nameof(Name)} = {Name}, {nameof(Permissions)}: {String.Join(Environment.NewLine, Permissions.Select(x => x.ToString()))}";
    }
}