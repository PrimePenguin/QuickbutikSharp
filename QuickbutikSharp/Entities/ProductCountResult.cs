using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class ProductCountResult
    {
        /// <summary>
        /// product id (Unique identifiers for the product)
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }
    }
}
