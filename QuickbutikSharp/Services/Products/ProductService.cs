﻿using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using QuickbutikSharp.Entities;
using QuickbutikSharp.Extensions;
using QuickbutikSharp.Infrastructure;

namespace QuickbutikSharp.Services.Products
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
        public virtual async Task<List<Product>> GetAsync(ProductListFilter filter = null)
        {
            var req = PrepareRequest("products");
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            return await ExecuteRequestAsync<List<Product>>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Returns product with specified product id
        /// </summary>
        public virtual async Task<Product> GetAsync(string productId)
        {
            var req = PrepareRequest("products");
            var filter = new ProductListFilter { IncludeDetails = "true", Limit = 1, ProductId = productId };
            req.QueryParams.AddRange(filter.ToQueryParameters());
            return await ExecuteRequestAsync<Product>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Returns product count
        /// </summary>
        public virtual async Task<ProductCountResult> CountAsync()
        {
            var req = PrepareRequest("products/count");
            return await ExecuteRequestAsync<ProductCountResult>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="request">Product information</param>
        /// <returns>The <see cref="Entities.Product"/>.</returns>
        public virtual async Task<Product> CreateAsync(CreateProductRequest request)
        {
            var req = PrepareRequest("products");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary();
                content = new JsonContent(body);
            }
            return await ExecuteRequestAsync<Product>(req, HttpMethod.Post, content);
        }

        /// <summary>
        /// Update products in store. <para>Product can be identified by product_id/variant_id or directly with SKU/Article Number if unique.</para>
        /// </summary>
        /// <param name="request">product to be updated</param>
        /// <returns>The <see cref="Entities.Product"/>.</returns>
        public virtual async Task<UpdateProductResponse> UpdateAsync(List<UpdateInventoryRequest> request)
        {
            var req = PrepareRequest("products");
            HttpContent content = null;

            if (request != null)
            {
                var body = request.ToDictionary(c => c);
                content = new JsonContent(body);
            }
            return await ExecuteRequestAsync<UpdateProductResponse>(req, HttpMethod.Put, content);
        }

        /// <summary>
        /// Returns metadata associated to product with specified product id
        /// </summary>
        public virtual async Task<Dictionary<string, string>> GetProductMetadataAsync(string productId)
        {
            var req = PrepareRequest($"metadata/product/{productId}");
            return await ExecuteRequestAsync<Dictionary<string, string>>(req, HttpMethod.Get);
        }
    }
}