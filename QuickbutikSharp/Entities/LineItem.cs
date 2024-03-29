﻿using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class LineItem
    {
        [JsonProperty("product_id")] public string ProductId { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("price")] public string Price { get; set; }

        [JsonProperty("qty")] public string Quantity { get; set; }

        [JsonProperty("variant")] public string Variant { get; set; }

        [JsonProperty("variant_id")] public string VariantId { get; set; }

        [JsonProperty("sku")] public string Sku { get; set; }

        [JsonProperty("app")]
        public App App { get; set; }
    }

    public partial class App
    {
        [JsonProperty("productpackages")]
        public Productpackage[] Productpackages { get; set; }
    }

    public partial class Productpackage
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("qty")]
        public string Qty { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }
}