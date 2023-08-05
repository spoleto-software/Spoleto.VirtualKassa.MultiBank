using System.Data;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierRole
    {
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }

        [JsonPropertyName("parent_role_id")]
        public string ParentRoleId { get; set; }

        [JsonPropertyName("role_code")]
        public string RoleCode { get; set; }

        [JsonPropertyName("sort")]
        public object Sort { get; set; }

        [JsonPropertyName("rights")]
        public List<CashierRight> Rights { get; set; }

        public override string ToString() => $"{nameof(RoleName)} = {RoleName}, {nameof(Rights)}: {String.Join(Environment.NewLine, Rights.Select(x => x.ToString()))}";
    }
}