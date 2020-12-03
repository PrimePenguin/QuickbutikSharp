using System;
using System.Net.Http;
using System.Threading.Tasks;
using QuickbutikSharp.Services.Products;

namespace QuickbutikSharp.Infrastructure
{
    public static class QuickbutikUtilities
    {
        public static async Task<bool> IsValidQuickbutikUri(string url)
        {
            using (var client = new HttpClient())
            {
                using (var msg = new HttpRequestMessage(HttpMethod.Get, url)
                {
                    Headers =
                    {
                        {"Accept", "application/json"},
                        {"user-agent", "PrimePenguin"}
                    }
                })
                {
                    try
                    {
                        var response = await client.SendAsync(msg);
                        if (!response.IsSuccessStatusCode) return false;

                        var message = await response.Content.ReadAsStringAsync();
                        return message.Contains("Quickbutik", StringComparison.OrdinalIgnoreCase);
                    }
                    catch (HttpRequestException)
                    {
                        return false;
                    }
                }
            }
        }

        public static async Task<bool> IsValidApiKey(string apiKey)
        {
            var productService = new ProductService(apiKey);
            try
            {
                await productService.CountAsync();
                return true;
            }
            catch (QuickbutikException)
            {
                return false;
            }
        }
    }
}