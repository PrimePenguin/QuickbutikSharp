using Newtonsoft.Json;

namespace QuickbutikSharp.Entities
{
    public class Image
    {
        [JsonProperty("image")] public string ImageUrl { get; set; }

        [JsonProperty("alttext")] public object AltText { get; set; }
    }
}