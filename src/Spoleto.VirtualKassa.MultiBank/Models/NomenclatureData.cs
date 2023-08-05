using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class NomenclatureData
    {
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        [JsonPropertyName("parent_product_id")]
        public string ParentProductId { get; set; }

        [JsonPropertyName("is_group")]
        public bool IsGroup { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("product_type")]
        public int? ProductType { get; set; }

        [JsonPropertyName("product_unit")]
        public int? ProductUnit { get; set; }

        [JsonPropertyName("product_price")]
        public decimal? ProductPrice { get; set; }

        [JsonPropertyName("product_without_vat")]
        public bool? ProductWithoutVat { get; set; }

        [JsonPropertyName("product_vat_percent")]
        public decimal? ProductVatPercent { get; set; }

        [JsonPropertyName("product_article")]
        public string ProductArticle { get; set; }

        [JsonPropertyName("product_barcode")]
        public string ProductBarcode { get; set; }

        [JsonPropertyName("product_mark")]
        public bool ProductMark { get; set; }

        [JsonPropertyName("product_external_id")]
        public string ProductExternalId { get; set; }

        [JsonPropertyName("classifier_class_code")]
        public string ClassifierClassCode { get; set; }

        [JsonPropertyName("classifier_group_code")]
        public string ClassifierGroupCode { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("product_name_gs1")]
        public string ProductNameGs1 { get; set; }

        [JsonPropertyName("product_image_path")]
        public string ProductImagePath { get; set; }

        [JsonPropertyName("product_image")]
        public string ProductImage { get; set; }

        [JsonPropertyName("product_in_gs1")]
        public bool? ProductInGs1 { get; set; }

        [JsonPropertyName("commitent_tin")]
        public string CommitentTin { get; set; }

        public override string ToString() => $"{nameof(ProductName)} = {ProductName}, {nameof(ProductPrice)} = {ProductPrice}";
    }
}