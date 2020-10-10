using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_v2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Topic> Topics { get; set; }
    }
}
