using Newtonsoft.Json;

namespace AppDotNet.Entities
{
    public class Description
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("html")]
        public string Html { get; set; }
        [JsonProperty("entities")]
        public Entities Entities { get; set; }
    }
}