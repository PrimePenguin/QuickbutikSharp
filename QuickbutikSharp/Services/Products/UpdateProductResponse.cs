using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickbutikSharp.Services.Products
{
    public class UpdateProductResponse
    {
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("variants")]
        public List<string> Variants { get; set; }

        [JsonProperty("success")]
        public long Success { get; set; }
    }
}
