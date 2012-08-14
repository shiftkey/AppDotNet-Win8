using Newtonsoft.Json;

namespace AppDotNet.Entities
{
    public class Counts
    {
        [JsonProperty("follows")]
        public int Follows { get; set; }
        [JsonProperty("followed_by")]
        public int FollowedBy { get; set; }
        [JsonProperty("posts")]
        public int Posts { get; set; }
    }
}