using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class FavoritesRecommendedPost : Entity<int>
    {
        public int user_id { get; set; }
        public int recommended_post_id { get; set; }
        public User User { get; set; }
        public RecommendedPost RecommendedPost { get; set; }
    }
}
