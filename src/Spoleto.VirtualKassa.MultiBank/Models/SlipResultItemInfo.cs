using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipResultItemInfo
    {
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
        public int ProductPrice { get; set; }

        [JsonPropertyName("total_product_price")]
        public int TotalProductPrice { get; set; }

        [JsonPropertyName("product_without_vat")]
        public bool ProductWithoutVat { get; set; }

        [JsonPropertyName("product_discount")]
        public int ProductDiscount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("product_vat_percent")]
        public int ProductVatPercent { get; set; }

        [JsonPropertyName("other")]
        public int Other { get; set; }

        [JsonPropertyName("total_sum")]
        public int TotalSum { get; set; }

        [JsonPropertyName("total_discount")]
        public int TotalDiscount { get; set; }

        [JsonPropertyName("total_price")]
        public int TotalPrice { get; set; }

        [JsonPropertyName("SPIC")]
        public string SPIC { get; set; }

        [JsonPropertyName("Discount")]
        public int Discount { get; set; }

        [JsonPropertyName("Price")]
        public int Price { get; set; }

        [JsonPropertyName("Barcode")]
        public string Barcode { get; set; }

        [JsonPropertyName("Amount")]
        public int Amount { get; set; }

        [JsonPropertyName("Units")]
        public int Units { get; set; }

        [JsonPropertyName("PackageCode")]
        public string PackageCode { get; set; }

        [JsonPropertyName("Label")]
        public string Label { get; set; }

        [JsonPropertyName("VAT")]
        public int VAT { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("receipt_item_id")]
        public string ReceiptItemId { get; set; }

        [JsonPropertyName("product_hotkey_name")]
        public string ProductHotkeyName { get; set; }

        [JsonPropertyName("receipt_item_gnk_barcode")]
        public string ReceiptItemGnkBarcode { get; set; }

        [JsonPropertyName("vat")]
        public double Vat { get; set; }

        [JsonPropertyName("receipt_item_gnk_name")]
        public string ReceiptItemGnkName { get; set; }

        [JsonPropertyName("receipt_item_mark")]
        public bool ReceiptItemMark { get; set; }

        [JsonPropertyName("receipt_item_gnk_discount")]
        public int ReceiptItemGnkDiscount { get; set; }

        [JsonPropertyName("receipt_item_qty")]
        public int ReceiptItemQty { get; set; }

        [JsonPropertyName("receipt_item_gnk_price")]
        public int ReceiptItemGnkPrice { get; set; }

        [JsonPropertyName("receipt_item_gnk_amount")]
        public int ReceiptItemGnkAmount { get; set; }

        [JsonPropertyName("receipt_item_per_vat")]
        public int ReceiptItemPerVat { get; set; }

        [JsonPropertyName("receipt_item_gnk_vat")]
        public int ReceiptItemGnkVat { get; set; }

        [JsonPropertyName("receipt_item_classifier_class_code")]
        public string ReceiptItemClassifierClassCode { get; set; }

        [JsonPropertyName("VATPercent")]
        public int VATPercent { get; set; }

        [JsonPropertyName("useWeight")]
        public string UseWeight { get; set; }

        [JsonPropertyName("product_vat_string")]
        public string ProductVatString { get; set; }

        [JsonPropertyName("OwnerType")]
        public int OwnerType { get; set; }

        public override string ToString() => $"{nameof(ProductName)} = {ProductName}, {nameof(TotalProductPrice)} = {TotalProductPrice}";
    }
}
