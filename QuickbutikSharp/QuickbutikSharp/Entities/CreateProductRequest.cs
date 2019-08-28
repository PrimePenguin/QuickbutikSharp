using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class CreateProductRequest
    {
        /// <summary>
        /// item number 
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// product Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Purchase price (excl. VAT)
        /// </summary>
        [JsonProperty("purchase_price")]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// Price comparison
        /// </summary>
        [JsonProperty("before_price")]
        public string BeforePrice { get; set; }

        /// <summary>
        /// VAT Rate
        /// </summary>
        [JsonProperty("tax_rate")]
        public int? TaxRate { get; set; }

        /// <summary>
        /// Availability 
        /// </summary>
        [JsonProperty("stock")]
        public int Stock { get; set; }

        /// <summary>
        /// head category name
        /// </summary>
        [JsonProperty("headcategory_name")]
        public string HeadCategoryName { get; set; }

        /// <summary>
        /// disable negative storage
        /// </summary>
        [JsonProperty("disable_minusqty")]
        public string DisableMinusQuantity { get; set; }

        /// <summary>
        /// EAN Code
        /// </summary>
        [JsonProperty("gtin")]
        public string EANCode { get; set; }
        [JsonProperty("visible")] public int Visible { get; set; }
    }
}