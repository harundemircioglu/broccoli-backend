using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PostsImageResponseDto
    {
        public int Id { get; set; }
        public int post_id { get; set; }
        public string image_url { get; set; }
        public PostResponseDto Post { get; set; }
    }
}
