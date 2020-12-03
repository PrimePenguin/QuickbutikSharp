using Newtonsoft.Json;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Services.Product
{
    public class ProductListFilter : Parameterizable
    {
        /// <summary>
        /// Specific id for product
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// The maximum number of rows returned. The default is 100, and the value may not exceed 500.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The amount of rows to skip before returning. This can be used to loop through all objects if there are more than the limit allows to be returned.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Indicates whether or not details are returned.
        /// </summary>
        [JsonProperty("include_details")]
        public string IncludeDetails { get; set; }
    }
}
