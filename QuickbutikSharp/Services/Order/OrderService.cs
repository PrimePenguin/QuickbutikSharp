using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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
        /// Returns collection of orders
        /// </summary>
        public virtual async Task<List<Entities.Order>> GetAsync()
        {
            var req = PrepareRequest($"orders");
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
        /// update an existing order
        /// </summary>
        /// <param name="request">order to be updated</param>
        public virtual async Task<Dictionary<string, UpdateOrderResponse>> UpdateAsync(List<UpdateOrderRequest> request)
        {
            var req = PrepareRequest($"orders");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary(x => x);
                content = new JsonContent(body);
            }
            return await ExecuteRequestAsync<Dictionary<string, UpdateOrderResponse>>(req, HttpMethod.Put, content);
        }
    }
}