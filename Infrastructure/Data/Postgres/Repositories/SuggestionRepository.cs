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
    public class SuggestionRepository : Repository<Suggestion, int>, ISuggestionRepository
    {
        public SuggestionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Suggestion>> GetAllAsync(Expression<Func<Suggestion, bool>>? filter = null)
        {
            var suggestion = PostgresContext.Set<Suggestion>()
                .Include(p => p.Category);
            return filter == null
                ? await suggestion.ToListAsync()
                : await suggestion.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Suggestion>> GetBySuggestionIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
