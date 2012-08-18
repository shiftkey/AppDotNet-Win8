using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotNet.Entities
{
    public class Source
    {
        public string name { get; set; }
        public string link { get; set; }
    }

    public class WellknownGeo
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Annotations
    {
        public WellknownGeo geo { get; set; }
    }
    
    public class Post
    {
        public string id { get; set; }
        public User user { get; set; }
        public string created_at { get; set; }
        public string text { get; set; }
        public string html { get; set; }
        public Source source { get; set; }
        public object reply_to { get; set; }
        public string thread_id { get; set; }
        public int num_replies { get; set; }
        public Annotations annotations { get; set; }
        public Entities entities { get; set; }
    }
}
