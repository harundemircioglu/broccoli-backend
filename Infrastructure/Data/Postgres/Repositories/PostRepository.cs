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
    public class PostRepository : Repository<Post, int>, IPostRepository
    {
        public PostRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Post>> GetAllAsync(Expression<Func<Post, bool>>? filter = null)
        {
            var post = PostgresContext.Set<Post>()
                .Include(p => p.User)
                .Include(p => p.Category);

            return filter == null
                ? await post.ToListAsync()
                : await post.Where(filter)
                .ToListAsync();
        }

        public async Task<IList<Post>> GetByUserIdAsync(int userId)
        {
            var post = PostgresContext.Set<Post>()
                .Include(p => p.User)
                .Where(fp => fp.user_id == userId);

            return await post.ToListAsync();
        }

        public Task<IList<Post>> GetByPostIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
