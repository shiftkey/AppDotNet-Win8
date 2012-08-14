using System.Collections.Generic;

namespace AppDotNet.Entities
{
    public class Mention
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<int> indices { get; set; }
    }
}