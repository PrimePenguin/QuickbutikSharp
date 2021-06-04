using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuickbutikSharp.Entities;
using QuickbutikSharp.Extensions;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Services.Orders
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
        public virtual async Task<List<Order>> GetAsync(OrdersQueryRequest query = null)
        {
            var req = PrepareRequest("orders");
            if (query != null)
            {
                req.QueryParams.AddRange(query.ToQueryParameters());
            }

            try
            {
                return await ExecuteRequestAsync<List<Order>>(req, HttpMethod.Get);
            }
            catch (QuickbutikException e)
            {
                if (e.Code == 404)
                {
                    return new List<Order>();
                }
                throw;
            }
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