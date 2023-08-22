using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class PostCreateDto
    {
        public int user_id { get; set; }
        public int category_id { get; set; }
        public string post_header { get; set; }
        public string post_detail { get; set; }
        public int popularity { get; set; }
    }
}
