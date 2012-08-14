using System.Collections.Generic;

namespace AppDotNet.Entities
{
    public class Entities
    {
        public List<Mention> mentions { get; set; }
        public List<Hashtag> hashtags { get; set; }
        public List<Link> links { get; set; }
    }
}