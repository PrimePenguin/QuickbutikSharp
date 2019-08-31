using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateProductRequest
    {
        /// <summary>
        /// Product ID - that you want to update
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Product variant ID - that you want to update (if it is a variant)
        /// </summary>
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        /// <summary>
        /// (OR) Article number - on the product / variant you wish to update
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Purchase price (excl. VAT)
        /// </summary>
        [JsonProperty("purchase_price")]
        public int? PurchasePrice { get; set; }

        /// <summary>
        /// Price comparison
        /// </summary>
        [JsonProperty("before_price")]
        public int? BeforePrice { get; set; }

        /// <summary>
        /// VAT Rate
        /// </summary>
        [JsonProperty("tax_rate")]
        public int? TaxRate { get; set; }

        /// <summary>
        /// disable negative storage
        /// </summary>
        [JsonProperty("disable_minusqty")]
        public string DisableMinusQuantity { get; set; }

        [JsonProperty("visible")] public int Visible { get; set; }
    }
}