using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class ShippingInfo
    {
        /// <summary>
        /// tracking number
        /// </summary>
        [JsonProperty("trackingnumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// shipping company
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }
    }
}