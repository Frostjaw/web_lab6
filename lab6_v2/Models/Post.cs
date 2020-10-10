using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_v2.Models
{
    public class Post
    {

        public Post()
        {
            Images = new List<Image>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
