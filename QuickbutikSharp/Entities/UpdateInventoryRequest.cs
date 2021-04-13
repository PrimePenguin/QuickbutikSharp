using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateInventoryRequest
    {
        /// <summary>
        /// Product ID - that you want to update
        /// </summary>
        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Product variant ID - that you want to update (if it is a variant)
        /// </summary>
        [JsonProperty("variant_id")]
        public int? VariantId { get; set; }

        /// <summary>
        ///  Availability
        /// </summary>
        [JsonProperty("stock")]
        public int? Stock { get; set; }

        /// <summary>
        /// dont allow the stock to go negative
        /// </summary>
        [JsonProperty("disable_minusqty")]
        public string DisableMinusQty { get; set; }

        /// <summary>
        /// Article Number - on product/variant which you would like to update.
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// dont allow the stock to go negative
        /// </summary>
        [JsonProperty("visible")]
        public int? Visible { get; set; }
    }
}