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
    public class SuggestionsImageRepository : Repository<SuggestionsImage, int>, ISuggestionsImageRepository
    {
        public SuggestionsImageRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<SuggestionsImage>> GetAllAsync(Expression<Func<SuggestionsImage, bool>>? filter = null)
        {
            var suggestionsImage = PostgresContext.Set<SuggestionsImage>()
                .Include(p => p.Suggestion);
            return filter == null
                ? await suggestionsImage.ToListAsync()
                : await suggestionsImage.Where(filter)
                .ToListAsync();
        }

        public Task<IList<SuggestionsImage>> GetBySuggestionsImageIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
