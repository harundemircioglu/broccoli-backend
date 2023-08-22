using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class FavoritesRecommendedPostRepository : Repository<FavoritesRecommendedPost, int>, IFavoritesRecommendedPostRepository
    {
        public FavoritesRecommendedPostRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<FavoritesRecommendedPost>> GetAllAsync(Expression<Func<FavoritesRecommendedPost, bool>>? filter = null)
        {
            var favoritesRecommendedPost = PostgresContext.Set<FavoritesRecommendedPost>()
                .Include(p => p.User)
                .Include(p => p.RecommendedPost);

            return filter == null
                ? await favoritesRecommendedPost.ToListAsync()
                : await favoritesRecommendedPost.Where(filter)
                .ToListAsync();
        }

        public Task<IList<FavoritesRecommendedPost>> GetByFavoritesRecommendedPostIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
