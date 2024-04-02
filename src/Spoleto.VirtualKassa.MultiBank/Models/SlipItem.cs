using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipItem
    {
        [JsonPropertyName("CommissionInfo")]
        public CommissionInfo CommissionInfo { get; set; }

        [JsonPropertyName("classifier_class_code")]
        public string ClassifierClassCode { get; set; }

        [JsonPropertyName("product_mark")]
        public bool ProductMark { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("product_label")]
        public string ProductLabel { get; set; }

        [JsonPropertyName("product_barcode")]
        public string ProductBarcode { get; set; }

        [JsonPropertyName("product_price")]
        public decimal ProductPrice { get; set; }

        [JsonPropertyName("total_product_price")]
        public decimal TotalProductPrice { get; set; }

        [JsonPropertyName("product_without_vat")]
        public bool ProductWithoutVat { get; set; }

        [JsonPropertyName("product_discount")]
        public decimal ProductDiscount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; } = 1;

        [JsonPropertyName("product_vat_percent")]
        public decimal ProductVatPercent { get; set; }

        [JsonPropertyName("other")]
        public decimal Other { get; set; }

        /// <summary>
        /// Код единицы измерения (упаковки).
        /// </summary>
        /// <remarks>
        /// Примеры:<br/>
        /// "1425694"<br/>
        /// "1340942"
        /// </remarks>
        [JsonPropertyName("product_package")]
        public string ProductPackage { get; set; }

        /// <summary>
        /// Наименование единицы измерения (упаковки) латиницей.
        /// </summary>
        /// <remarks>
        /// Примеры:<br/>
        /// "kilogramm"<br/>
        /// "dona (banka) 2000 millilitr"
        /// </remarks>
        [JsonPropertyName("product_package_name")]
        public string ProductPackageName { get; set; }

        public override string ToString() => $"{nameof(ProductName)} = {ProductName}, {nameof(TotalProductPrice)} = {TotalProductPrice}";
    }
}
