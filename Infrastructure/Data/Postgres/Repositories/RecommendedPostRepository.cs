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
    public class RecommendedPostRepository : Repository<RecommendedPost, int>, IRecommendedPostRepository
    {
        public RecommendedPostRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }
        public async Task<IList<RecommendedPost>> GetAllAsync(Expression<Func<RecommendedPost, bool>>? filter = null)
        {
            var recommendedPost = PostgresContext.Set<RecommendedPost>()
                .Include(p => p.Category);

            return filter == null
                ? await recommendedPost.ToListAsync()
                : await recommendedPost.Where(filter)
                .ToListAsync();
        }

        public Task<IList<RecommendedPost>> GetByRecommendedPostIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
