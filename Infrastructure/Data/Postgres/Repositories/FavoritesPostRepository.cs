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
    public class FavoritesPostRepository : Repository<FavoritesPost, int>, IFavoritesPostRepository
    {
        public FavoritesPostRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<FavoritesPost>> GetAllAsync(Expression<Func<FavoritesPost, bool>>? filter = null)
        {
            var favoritesPost = PostgresContext.Set<FavoritesPost>()
                .Include(p => p.User)
                .Include(p => p.Post);

            return filter == null
                ? await favoritesPost.ToListAsync()
                : await favoritesPost.Where(filter)
                .ToListAsync();
        }
        public async Task<IList<FavoritesPost>> GetByUserIdAsync(int userId)
        {
            var favoritesPost = PostgresContext.Set<FavoritesPost>()
                .Include(p => p.User)
                .Include(p => p.Post)
                .ThenInclude(p => p.User)
                .Where(fp => fp.user_id == userId);

            return await favoritesPost.ToListAsync();
        }

        public Task<IList<FavoritesPost>> GetByFavoritesPostIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
