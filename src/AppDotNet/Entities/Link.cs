using System.Collections.Generic;

namespace AppDotNet.Entities
{
    public class Link
    {
        public string text { get; set; }
        public string url { get; set; }
        public List<int> indices { get; set; }
    }
}