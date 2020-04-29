using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class Customer
    {
        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("phone")] public string Phone { get; set; }

        [JsonProperty("customer_type")] public string CustomerType { get; set; }

        [JsonProperty("company_name")] public string CompanyName { get; set; }

        [JsonProperty("full_name")] public string FullName { get; set; }

        [JsonProperty("address")] public string Address { get; set; }

        [JsonProperty("address2")] public string Address2 { get; set; }

        [JsonProperty("city")] public string City { get; set; }

        [JsonProperty("zipcode")] public string ZipCode { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("notes")] public string Notes { get; set; }
    }
}