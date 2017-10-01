using System.Collections.Generic;

namespace AIRA.UI.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<News> News { get; set; }
    }
}