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
    public class FavoritesSuggestionRepository : Repository<FavoritesSuggestion, int>, IFavoritesSuggestionRepository
    {
        public FavoritesSuggestionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<FavoritesSuggestion>> GetAllAsync(Expression<Func<FavoritesSuggestion, bool>>? filter = null)
        {
            var favoritesSuggestion = PostgresContext.Set<FavoritesSuggestion>()
                .Include(p => p.User)
                .Include(p => p.Suggestion);
            return filter == null
                ? await favoritesSuggestion.ToListAsync()
                : await favoritesSuggestion.Where(filter)
                .ToListAsync();
        }

        public Task<IList<FavoritesSuggestion>> GetByFavoritesSuggestionIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
