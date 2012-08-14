using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppDotNet.Entities
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public Description description { get; set; }
        public string timezone { get; set; }
        public string locale { get; set; }
        public AvatarImage avatar_image { get; set; }
        public CoverImage cover_image { get; set; }
        public string type { get; set; }
        public string created_at { get; set; }
        public Counts counts { get; set; }
    }

    public class Mention
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<int> indices { get; set; }
    }

    public class Hashtag
    {
        public string name { get; set; }
        public List<int> indices { get; set; }
    }

    public class Link
    {
        public string text { get; set; }
        public string url { get; set; }
        public List<int> indices { get; set; }
    }

    public class Entities
    {
        public List<Mention> mentions { get; set; }
        public List<Hashtag> hashtags { get; set; }
        public List<Link> links { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public string html { get; set; }
        public Entities entities { get; set; }
    }

    public class AvatarImage
    {
        public int height { get; set; }
        public int width { get; set; }
        public string url { get; set; }
    }

    public class CoverImage
    {
        public int height { get; set; }
        public int width { get; set; }
        public string url { get; set; }
    }

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
