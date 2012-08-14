using System.Collections.Generic;

namespace AppDotNet.Entities
{
    public class Hashtag
    {
        public string name { get; set; }
        public List<int> indices { get; set; }
    }
}