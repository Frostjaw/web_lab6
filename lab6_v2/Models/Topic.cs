using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_v2.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string UserName { get; set; }

        public Category Category { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
