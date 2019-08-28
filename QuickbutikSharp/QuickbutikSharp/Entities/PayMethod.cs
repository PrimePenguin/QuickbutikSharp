using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class PayMethod
    {
        [JsonProperty("method")] public string Method { get; set; }

        [JsonProperty("transaction_id")] public string TransactionId { get; set; }
    }
}