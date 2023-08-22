using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Comment : Entity<int>
    {
        public int user_id { get; set; }
        public int post_id { get; set; }
        public string comment_header { get; set; }
        public string comment_detail { get; set; }
        public int popularity { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
