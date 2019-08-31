using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateOrderRequest
    {
        /// <summary>
        /// order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// order status, ExampleL done, cancelled
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// shipping info
        /// </summary>
        [JsonProperty("shipping_info")]
        public ShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// Optional: In connection with status done . Send shipping confirmation to customer?
        /// </summary>
        [JsonProperty("email_confirmation")]
        public bool EmailConfirmation { get; set; }
    }
}