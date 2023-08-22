using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class RecommendedPost : Entity<int>
    {
        public string post_header { get; set; }
        public string post_detail { get; set; }
        public int category_id { get; set; }
        public int popularity { get; set; }
        public Category Category { get; set; }
        public ICollection<RecommendedPostsImage> RecommendedPostsImages { get; set; }
        public ICollection<FavoritesRecommendedPost> FavoritesRecommendedPosts { get; set; }
    }
}
