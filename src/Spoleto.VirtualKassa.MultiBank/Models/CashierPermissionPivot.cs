using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class CashierPermissionPivot
    {
        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }

        [JsonPropertyName("permission_id")]
        public int PermissionId { get; set; }
    }
}