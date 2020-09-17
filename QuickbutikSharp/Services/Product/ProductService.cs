using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using QuickbutikSharp.Entities;
using QuickbutikSharp.Extensions;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Services.Product
{
    public class ProductService : QuickbutikService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductService" />.
        /// </summary>
        /// <param name="apiKey">App Secret Api Key</param>
        public ProductService(string apiKey) : base(apiKey)
        {
        }

        /// <summary>
        /// Fetch products in store
        /// </summary>
        public virtual async Task<List<Entities.Product>> GetAsync()
        {
            var req = PrepareRequest($"products");
            return await ExecuteRequestAsync<List<Entities.Product>>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Returns product with specified product id
        /// </summary>
        public virtual async Task<Entities.Product> GetAsync(string productId)
        {
            var req = PrepareRequest($"products?product_id={productId}");
            return await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="request">Product information</param>
        /// <returns>The <see cref="Entities.Product"/>.</returns>
        public virtual async Task<Entities.Product> CreateAsync(CreateProductRequest request)
        {
            var req = PrepareRequest($"products");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary();
                content = new JsonContent(body);
            }
            return await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Post, content);
        }

        /// <summary>
        /// Update products in store. <para>Product can be identified by product_id/variant_id or directly with SKU/Article Number if unique.</para>
        /// </summary>
        /// <param name="request">product to be updated</param>
        /// <returns>The <see cref="Entities.Product"/>.</returns>
        public virtual async Task UpdateAsync(List<UpdateInventoryRequest> request)
        {
            var req = PrepareRequest($"products");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary(x => x);
                content = new JsonContent(body);
            }
            await ExecuteRequestAsync<object>(req, HttpMethod.Put, content);
        }
    }
}