using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class Order
    {
        /// <summary>
        /// order id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// order created date
        /// </summary>
        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        /// <summary>
        /// order paid date
        /// </summary>
        [JsonProperty("date_paid")]
        public string DatePaid { get; set; }

        /// <summary>
        /// order status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// shipping amount
        /// </summary>
        [JsonProperty("shipping_amount")]
        public string ShippingAmount { get; set; }

        /// <summary>
        /// shipping Id
        /// </summary>
        [JsonProperty("shipping_id")]
        public string ShippingId { get; set; }

        /// <summary>
        /// total amount
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// discounted amount
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// total pay amount
        /// </summary>
        [JsonProperty("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// tax amount
        /// </summary>
        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// notes
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        ///  shipping name
        /// </summary>
        [JsonProperty("shipping_name")]
        public string ShippingName { get; set; }

        /// <summary>
        ///  ordered products
        /// </summary>
        [JsonProperty("products")]
        public IEnumerable<LineItem> Products { get; set; }

        /// <summary>
        /// customer
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// pay method
        /// </summary>
        [JsonProperty("paymethod")]
        public PayMethod PayMethod { get; set; }

        [JsonProperty("items_amount")] public string ItemsAmount { get; set; }

        [JsonProperty("is_taxfree")] public bool IsTaxFree { get; set; }

        [JsonProperty("is_taxontop")] public bool IsTaxOnTop { get; set; }
    }
}