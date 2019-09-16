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
    }
}