using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuChangeHistoryDataData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("pkey")]
        public object Pkey { get; set; }

        [JsonPropertyName("parentPkey")]
        public object ParentPkey { get; set; }

        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("groupNameUz")]
        public string GroupNameUz { get; set; }

        [JsonPropertyName("groupNameRu")]
        public string GroupNameRu { get; set; }

        [JsonPropertyName("groupNameLat")]
        public object GroupNameLat { get; set; }

        [JsonPropertyName("classNameUz")]
        public string ClassNameUz { get; set; }

        [JsonPropertyName("classNameRu")]
        public string ClassNameRu { get; set; }

        [JsonPropertyName("classNameLat")]
        public object ClassNameLat { get; set; }

        [JsonPropertyName("positionNameUz")]
        public string PositionNameUz { get; set; }

        [JsonPropertyName("positionNameRu")]
        public string PositionNameRu { get; set; }

        [JsonPropertyName("positionNameLat")]
        public object PositionNameLat { get; set; }

        [JsonPropertyName("subPositionNameUz")]
        public string SubPositionNameUz { get; set; }

        [JsonPropertyName("subPositionNameRu")]
        public string SubPositionNameRu { get; set; }

        [JsonPropertyName("subPositionNameLat")]
        public object SubPositionNameLat { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("attributeNameUz")]
        public string AttributeNameUz { get; set; }

        [JsonPropertyName("attributeNameRu")]
        public string AttributeNameRu { get; set; }

        [JsonPropertyName("attributeNameLat")]
        public object AttributeNameLat { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("isActive")]
        public string IsActive { get; set; }

        [JsonPropertyName("createdAt")]
        public long CreatedAt { get; set; }

        [JsonPropertyName("updatedBy")]
        public object UpdatedBy { get; set; }

        [JsonPropertyName("updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("label")]
        public int Label { get; set; }

        [JsonPropertyName("packageNames")]
        public List<PackageName> PackageNames { get; set; }

        public override string ToString() => $"{nameof(AttributeNameRu)} = {AttributeNameRu}, {nameof(Status)} = {Status}";
    }
}