using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateOrderResult
    {
        [JsonProperty("results")]
        public Dictionary<string, UpdateOrderResponse> Results { get; set; }
    }

    public class UpdateOrderResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }
}
