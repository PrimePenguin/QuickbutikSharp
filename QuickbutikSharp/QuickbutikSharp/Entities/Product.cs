﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class Product
    {
        /// <summary>
        /// product id (Unique identifiers for the product)
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// item number 
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// has variants
        /// </summary>
        [JsonProperty("hasVariants")]
        public string HasVariants { get; set; }

        /// <summary>
        /// product Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// quantity
        /// </summary>
        [JsonProperty("qty")]
        public string Quantity { get; set; }

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
        public string TaxRate { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// seo title
        /// </summary>
        [JsonProperty("seo_title")]
        public string SeoTitle { get; set; }

        /// <summary>
        /// seo description
        /// </summary>
        [JsonProperty("seo_description")]
        public string SeoDescription { get; set; }

        /// <summary>
        /// Weight (in grams)
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// date modified
        /// </summary>
        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

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
        /// supplier name
        /// </summary>
        [JsonProperty("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// supplier sku
        /// </summary>
        [JsonProperty("supplier_sku")]
        public string SupplierSku { get; set; }

        /// <summary>
        /// image
        /// </summary>
        [JsonProperty("images")]
        public Dictionary<string, Image> Images { get; set; }

        /// <summary>
        /// variants
        /// </summary>
        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }

        [JsonProperty("visible")] public int Visible { get; set; }

        /// <summary>
        /// EAN code
        /// </summary>
        [JsonProperty("gtin")] public string EANCode { get; set; }
    }
}