using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Category : Entity<int>
    {
        public string category_name { get; set; }
        public int popularity { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<RecommendedPost> RecommendedPosts { get; set; }
        public ICollection<Suggestion> Suggestions { get; set; }
    }
}
