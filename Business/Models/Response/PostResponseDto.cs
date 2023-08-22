using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PostResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int category_id { get; set; }
        public string post_header { get; set; }
        public string post_detail { get; set; }
        public int popularity { get; set; }
        public UserProfileDto User { get; set; }
        public CategoryResponseDto Category { get; set; }
    }
}
