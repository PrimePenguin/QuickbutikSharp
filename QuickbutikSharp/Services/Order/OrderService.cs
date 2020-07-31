using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuickbutikSharp.Entities;
using QuickbutikSharp.Extensions;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Services.Order
{
    public class OrderService : QuickbutikService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderService" />.
        /// </summary>
        /// <param name="apiKey">App Secret Api Key</param>
        public OrderService(string apiKey) : base(apiKey)
        {
        }

        /// <summary>
        /// Fetch store orders.
        /// </summary>
        public virtual async Task<List<Entities.Order>> GetAsync(OrdersQueryRequest query)
        {
            var rqBuilder = new StringBuilder();

            rqBuilder.Append("orders");
            if (!string.IsNullOrEmpty(query.FromDatePaid)) rqBuilder.Append($"?from_date_paid={query.FromDatePaid}");

            if (!string.IsNullOrEmpty(query.FromStatusDate))
            {
                var separator = rqBuilder.ToString().Contains("?") ? "&" : "?";
                rqBuilder.Append($"{separator}from_status_date={query.FromStatusDate}");
            }

            if (!string.IsNullOrEmpty(query.Status))
            {
                var separator = rqBuilder.ToString().Contains("?") ? "&" : "?";
                rqBuilder.Append($"{separator}status={query.Status}");
            }

            var req = PrepareRequestForSingleEntity(rqBuilder.ToString());
            return await ExecuteRequestAsync<List<Entities.Order>>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Returns order with specified order id
        /// </summary>
        public virtual async Task<Entities.Order> GetAsync(string orderId)
        {
            var req = PrepareRequestForSingleEntity($"orders?order_id={orderId}");
            var orders = await ExecuteRequestAsync<Entities.Order[]>(req, HttpMethod.Get);
            return orders[0];
        }

        /// <summary>
        /// Update orders and add/modify order content.
        /// </summary>
        /// <param name="request">order to be updated</param>
        public virtual async Task<UpdateOrderResult> UpdateAsync(List<UpdateOrderRequest> request)
        {
            var req = PrepareRequest($"orders");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary(x => x);
                content = new JsonContent(body);
            }

            try
            {
                return await ExecuteRequestAsync<UpdateOrderResult>(req, HttpMethod.Put, content);
            }
            catch (JsonSerializationException)
            {
                return null;
            }
        }
    }
}