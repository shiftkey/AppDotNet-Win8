using Newtonsoft.Json;

namespace AppDotNet.Entities
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public Description Description { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("avatar_image")]
        public Image Avatar { get; set; }
        [JsonProperty("cover_image")]
        public Image Cover { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("counts")]
        public Counts Counts { get; set; }
    }
}
