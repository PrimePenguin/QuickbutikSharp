using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class Variant
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("ovalue_id_1")] public string OValueId1 { get; set; }

        [JsonProperty("product_id")] public string ProductId { get; set; }

        [JsonProperty("sku")] public string Sku { get; set; }

        [JsonProperty("qty")] public string Quantity { get; set; }

        [JsonProperty("price")] public string Price { get; set; }

        [JsonProperty("weight")] public string Weight { get; set; }

        [JsonProperty("before_price")] public string BeforePrice { get; set; }

        [JsonProperty("purchase_price")] public string PurchasePrice { get; set; }

        [JsonProperty("hidden")] public string Hidden { get; set; }

        [JsonProperty("values")] public List<Value> values { get; set; }

        /// <summary>
        /// EAN code
        /// </summary>
        [JsonProperty("gtin")]
        public string EANCode { get; set; }
    }

    public class Value
    {
        [JsonProperty("ovalue_field")]
        public string OValueField { get; set; }

        [JsonProperty("val")]
        public string Val { get; set; }
    }
}