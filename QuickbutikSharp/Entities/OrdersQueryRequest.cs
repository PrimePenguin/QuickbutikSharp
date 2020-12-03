using Newtonsoft.Json;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Entities
{
    public class OrdersQueryRequest : Parameterizable
    {
        /// <summary>
        /// Order number for the order you would like to load
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Fetch paid orders since a specific date. UNIX timestamp should be used here. <para>Example : 1596097247</para>
        /// </summary>
        [JsonProperty("from_date_paid")]
        public string FromDatePaid { get; set; }

        /// <summary>
        /// Fetch orders since a specific status transition date. UNIX timestamp should be used here.<para>Example : 1596097247</para>
        /// </summary>
        [JsonProperty("from_status_date")]
        public string FromStatusDate { get; set; }

        /// <summary>
        /// Fetch orders with a specific status. Can be used together with from_date_paid parameter.
        /// <para>Example : done, paid, unpaid</para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether or not details are returned.
        /// </summary>
        [JsonProperty("include_details")]
        public string IncludeDetails { get; set; }
    }
}
