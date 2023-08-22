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
    public class RecommendedPostsImageRepository : Repository<RecommendedPostsImage, int>, IRecommendedPostsImageRepository
    {
        public RecommendedPostsImageRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }
        public async Task<IList<RecommendedPostsImage>> GetAllAsync(Expression<Func<RecommendedPostsImage, bool>>? filter = null)
        {
            var recommendedPostsImage = PostgresContext.Set<RecommendedPostsImage>()
                .Include(p => p.RecommendedPost);
            return filter == null
                ? await recommendedPostsImage.ToListAsync()
                : await recommendedPostsImage.Where(filter)
                .ToListAsync();
        }

        public Task<IList<RecommendedPostsImage>> GetByRecommendedPostsImageIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
