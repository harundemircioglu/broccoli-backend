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
    public class PostsImageRepository : Repository<PostsImage, int>, IPostsImageRepository
    {
        public PostsImageRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<PostsImage>> GetAllAsync(Expression<Func<PostsImage, bool>>? filter = null)
        {
            var postsImage = PostgresContext.Set<PostsImage>()
                .Include(p => p.Post);

            return filter == null
                ? await postsImage.ToListAsync()
                : await postsImage.Where(filter)
                .ToListAsync();
        }

        public Task<IList<PostsImage>> GetByPostsImageIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
