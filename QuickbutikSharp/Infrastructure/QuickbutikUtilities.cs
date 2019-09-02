using System.Net.Http;
using System.Threading.Tasks;
using QuickbutikSharp.Services.Product;

namespace QuickbutikSharp.Infrastructure
{
    public static class QuickbutikUtilities
    {
        public static async Task<bool> IsValidQuickbutikUri(string url)
        {
            using (var client = new HttpClient())
            {
                using (var msg = new HttpRequestMessage(HttpMethod.Head, url)
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
                        return response.Headers.Contains("Set-Cookie");
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
                await productService.GetAsync();
                return true;
            }
            catch (QuickbutikException)
            {
                return false;
            }
        }
    }
}