using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_v2.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public byte[] Img { get; set; }

        public Post Post { get; set; }
    }
}
