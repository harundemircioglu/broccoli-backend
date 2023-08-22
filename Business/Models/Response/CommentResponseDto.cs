using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CommentResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int post_id { get; set; }
        public string comment_header { get; set; }
        public string comment_detail { get; set; }
        public int popularity { get; set; }
        public UserProfileDto User { get; set; }
        public PostResponseDto Post { get; set; }
    }
}
