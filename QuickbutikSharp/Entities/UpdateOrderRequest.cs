using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class UpdateOrderRequest
    {
        /// <summary>
        /// Enter order_id you would like to update status on.
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// Changes state of the order. Example: paid, done, cancelled
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

        /// <summary>
        /// Optional: In connection with the status paid.
        /// </summary>
        [JsonProperty("skip_email_confirmation")]
        public string SkipEmailConfirmation { get; set; }

        /// <summary>
        /// Optional: In connection with the status paid.
        /// </summary>
        [JsonProperty("skip_webhook")]
        public string SkipWebhook { get; set; }
    }
}