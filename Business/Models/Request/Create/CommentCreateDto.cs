using Business.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CommentCreateDto
    {
        public int user_id { get; set; }
        public int post_id { get; set; }
        public string comment_header { get; set; }
        public string comment_detail { get; set; }
        public int popularity { get; set; }
    }
}
