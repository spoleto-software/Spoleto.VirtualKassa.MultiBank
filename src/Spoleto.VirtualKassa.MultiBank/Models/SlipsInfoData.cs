using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Converters;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class SlipsInfoData
    {
        [JsonPropertyName("module_operation_type")]
        public string ModuleOperationType { get; set; }

        [JsonPropertyName("receipt_sum")]
        [JsonConverter(typeof(IntAsStringConverter))]
        public int ReceiptSum { get; set; }

        [JsonPropertyName("receipt_cashier_name")]
        public string ReceiptCashierName { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcash")]
        public int ReceiptGnkReceivedCash { get; set; }

        [JsonPropertyName("receipt_gnk_receivedcard")]
        public int ReceiptGnkReceivedCard { get; set; }

        [JsonPropertyName("receipt_gnk_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkTime { get; set; }

        [JsonPropertyName("total_discount")]
        public int TotalDiscount { get; set; }

        [JsonPropertyName("total_nds")]
        public double TotalNds { get; set; }

        [JsonPropertyName("items")]
        public string Items { get; set; }

        [JsonPropertyName("payment")]
        public SlipPayment Payment { get; set; }

        [JsonPropertyName("RefundInfo")]
        public RefundInfo RefundInfo { get; set; }

        [JsonPropertyName("contractor_name")]
        public string ContractorName { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        [JsonPropertyName("receipt_gnk_terminalid")]
        public string ReceiptGnkTerminalid { get; set; }

        [JsonPropertyName("receipt_gnk_qrcodeurl")]
        public string ReceiptGnkQrcodeurl { get; set; }

        [JsonPropertyName("receipt_gnk_receiptseq")]
        public int ReceiptGnkReceiptSeq { get; set; }

        [JsonPropertyName("receipt_gnk_fiscalsign")]
        public string ReceiptGnkFiscalSign { get; set; }

        [JsonPropertyName("receipt_gnk_appletversion")]
        [JsonConverter(typeof(StringAsIntStringConverter))]
        public string? ReceiptGnkAppletVersion { get; set; }

        [JsonPropertyName("receipt_gnk_datetime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ReceiptGnkDatetime { get; set; }

        //todo: нужен конвертер: приходит иногда строка, иногда объект
        //[JsonPropertyName("app")]
        //public string App { get; set; }

        [JsonPropertyName("demo")]
        public string Demo { get; set; }

        [JsonPropertyName("module_gnk_id")]
        public string ModuleGnkId { get; set; }

        [JsonPropertyName("module_operation_shift_id")]
        public string ModuleOperationShiftId { get; set; }

        [JsonPropertyName("use_warehouse")]
        public bool? UseWarehouse { get; set; }


        // Fields from json, not from the manual

        //[JsonPropertyName("opentime")]
        //public string OpenTime { get; set; }

        //[JsonPropertyName("lastoperation")]
        //public int? LastOperation { get; set; }

        //[JsonPropertyName("offline")]
        //public string Offline { get; set; }

        //[JsonPropertyName("module_operation_sum_input")]
        //public int? ModuleOperationSumInput { get; set; }

        //[JsonPropertyName("receipt_number")]
        //public int? ReceiptNumber { get; set; }

        //[JsonPropertyName("statusShift")]
        //public string StatusShift { get; set; }

        //[JsonPropertyName("TotalRefundCard")]
        //public int? TotalRefundCard { get; set; }

        //[JsonPropertyName("TotalRefundCash")]
        //public int? TotalRefundCash { get; set; }

        //[JsonPropertyName("TotalRefundCount")]
        //public int? TotalRefundCount { get; set; }

        //[JsonPropertyName("TotalRefundVAT")]
        //public int? TotalRefundVAT { get; set; }

        //[JsonPropertyName("TotalSaleCard")]
        //public int? TotalSaleCard { get; set; }

        //[JsonPropertyName("TotalSaleCash")]
        //public int? TotalSaleCash { get; set; }

        //[JsonPropertyName("TotalSaleCount")]
        //public int? TotalSaleCount { get; set; }

        //[JsonPropertyName("TotalSaleVAT")]
        //public int? TotalSaleVAT { get; set; }

        //[JsonPropertyName("module_operation_sum_card")]
        //public int? ModuleOperationSumCard { get; set; }

        //[JsonPropertyName("module_operation_sum_cash")]
        //public int? ModuleOperationSumCash { get; set; }

        //[JsonPropertyName("module_operation_sum_cash_ret")]
        //public int? ModuleOperationSumCashRet { get; set; }

        //[JsonPropertyName("module_operation_sum_return")]
        //public int? ModuleOperationSumReturn { get; set; }

        //[JsonPropertyName("module_operation_sum_sales")]
        //public int? ModuleOperationSumSales { get; set; }

        //[JsonPropertyName("closetime")]
        //public string Closetime { get; set; }

        //[JsonPropertyName("sale_count")]
        //public int? SaleCount { get; set; }

        //[JsonPropertyName("refund_count")]
        //public int? RefundCount { get; set; }

        //[JsonPropertyName("proceeds_cash")]
        //public int? ProceedsCash { get; set; }

        //[JsonPropertyName("proceeds_card")]
        //public int? ProceedsCard { get; set; }

        //[JsonPropertyName("vat")]
        //public int? Vat { get; set; }

        //[JsonPropertyName("vat_ret")]
        //public int? VatRet { get; set; }

        //[JsonPropertyName("proceeds")]
        //public int? Proceeds { get; set; }

        //[JsonPropertyName("total_all_sum")]
        //public int? TotalAllSum { get; set; }

        //[JsonPropertyName("total_sale_vat")]
        //public int? TotalSaleVat { get; set; }

        //[JsonPropertyName("total_refund_vat")]
        //public int? TotalRefundVat { get; set; }

        //[JsonPropertyName("force_to_print")]
        //public object ForceToPrint { get; set; }

        //[JsonPropertyName("receipt_traidpoint")]
        //public string ReceiptTraidpoint { get; set; }

        //[JsonPropertyName("receipt_address")]
        //public string ReceiptAddress { get; set; }

        //[JsonPropertyName("contragent_name")]
        //public string ContragentName { get; set; }

        //[JsonPropertyName("METHOD_NAME")]
        //public string METHODNAME { get; set; }

        //[JsonPropertyName("cashbox_serial")]
        //public string CashboxSerial { get; set; }

        //[JsonPropertyName("receipt_tin")]
        //public string ReceiptTin { get; set; }

        //[JsonPropertyName("templateWithNotValues")]
        //public List<TemplateWithNotValue> TemplateWithNotValues { get; set; }

        //[JsonPropertyName("templateFormated")]
        //public List<TemplateFormated> TemplateFormated { get; set; }

        //[JsonPropertyName("WELCOME")]
        //public string WELCOME { get; set; }

        //[JsonPropertyName("DISCOUNT")]
        //public string DISCOUNT { get; set; }

        //[JsonPropertyName("TOTAL_DISCOUNT")]
        //public string TOTALDISCOUNT { get; set; }

        //[JsonPropertyName("COMPANY_NAME")]
        //public object COMPANYNAME { get; set; }

        //[JsonPropertyName("TRADEPOINT_NAME")]
        //public object TRADEPOINTNAME { get; set; }

        //[JsonPropertyName("ADDRESS")]
        //public string ADDRESS { get; set; }

        //[JsonPropertyName("DATE_REGISTRATION")]
        //public string DATEREGISTRATION { get; set; }

        //[JsonPropertyName("INN")]
        //public string INN { get; set; }

        //[JsonPropertyName("FN")]
        //public string FN { get; set; }

        //[JsonPropertyName("CASHIER")]
        //public string CASHIER { get; set; }

        //[JsonPropertyName("CHECK_NUMBER")]
        //public string CHECKNUMBER { get; set; }

        //[JsonPropertyName("SHIFT_OPEN_TIME")]
        //public string SHIFTOPENTIME { get; set; }

        //[JsonPropertyName("OPEN_SHIFT_CASH")]
        //public string OPENSHIFTCASH { get; set; }

        //[JsonPropertyName("CONTRIBUTED")]
        //public string CONTRIBUTED { get; set; }

        //[JsonPropertyName("WITHDRAWN")]
        //public string WITHDRAWN { get; set; }

        //[JsonPropertyName("TOTAL_SALED")]
        //public string TOTALSALED { get; set; }

        //[JsonPropertyName("SALED_CASH")]
        //public string SALEDCASH { get; set; }

        //[JsonPropertyName("SALED_CARD")]
        //public string SALEDCARD { get; set; }

        //[JsonPropertyName("TOTAL_REFUND")]
        //public string TOTALREFUND { get; set; }

        //[JsonPropertyName("END_SHIFT_CASH")]
        //public string ENDSHIFTCASH { get; set; }

        //[JsonPropertyName("TOTAL_VAT")]
        //public string TOTALVAT { get; set; }

        //[JsonPropertyName("FISCAL_SIGN")]
        //public string FISCALSIGN { get; set; }

        //[JsonPropertyName("FISCAL_NUMBER")]
        //public string FISCALNUMBER { get; set; }

        //[JsonPropertyName("FISCAL_NUM")]
        //public string FISCALNUM { get; set; }

        //[JsonPropertyName("SALE")]
        //public string SALE { get; set; }

        //[JsonPropertyName("REFUND")]
        //public string REFUND { get; set; }

        //[JsonPropertyName("OPEN_SHIFT")]
        //public string OPENSHIFT { get; set; }

        //[JsonPropertyName("CLOSE_SHIFT")]
        //public string CLOSESHIFT { get; set; }

        //[JsonPropertyName("CURRENT_CASH")]
        //public string CURRENTCASH { get; set; }

        //[JsonPropertyName("SHIFT")]
        //public string SHIFT { get; set; }

        //[JsonPropertyName("VAT")]
        //public string VAT { get; set; }

        //[JsonPropertyName("TOTAL")]
        //public string TOTAL { get; set; }

        //[JsonPropertyName("PAYED")]
        //public string PAYED { get; set; }

        //[JsonPropertyName("HAVE_CASH")]
        //public string HAVECASH { get; set; }

        //[JsonPropertyName("REASON")]
        //public string REASON { get; set; }

        //[JsonPropertyName("TEXT1")]
        //public string TEXT1 { get; set; }

        //[JsonPropertyName("XREPORT")]
        //public string XREPORT { get; set; }

        //[JsonPropertyName("COPY")]
        //public string COPY { get; set; }

        //[JsonPropertyName("SALE_COUNT")]
        //public string SALECOUNT { get; set; }

        //[JsonPropertyName("RETURN_COUNT")]
        //public string RETURNCOUNT { get; set; }

        //[JsonPropertyName("CASHBOX_SERIAL")]
        //public string CASHBOXSERIAL { get; set; }

        //[JsonPropertyName("ODD_MONEY")]
        //public string ODDMONEY { get; set; }

        //[JsonPropertyName("WITHOUT_VAT")]
        //public string WITHOUTVAT { get; set; }

        //[JsonPropertyName("DATE")]
        //public string DATE { get; set; }

        //[JsonPropertyName("TIME")]
        //public string TIME { get; set; }

        //[JsonPropertyName("TOTAL_VAT_SALE")]
        //public string TOTALVATSALE { get; set; }

        //[JsonPropertyName("TOTAL_VAT_REFUND")]
        //public string TOTALVATREFUND { get; set; }

        //[JsonPropertyName("LABEL")]
        //public string LABEL { get; set; }

        //[JsonPropertyName("BARCODE")]
        //public string BARCODE { get; set; }

        //[JsonPropertyName("MXIK")]
        //public string MXIK { get; set; }

        //[JsonPropertyName("PAYER")]
        //public string PAYER { get; set; }

        //[JsonPropertyName("CASHBACK")]
        //public string CASHBACK { get; set; }

        //[JsonPropertyName("COMITENT")]
        //public string COMITENT { get; set; }

        //[JsonPropertyName("OWNER_TYPE")]
        //public string OWNERTYPE { get; set; }
    }
}