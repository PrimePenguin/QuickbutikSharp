using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateOrderResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }
}
