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
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Category>> GetAllAsync(Expression<Func<Category, bool>>? filter = null)
        {
            var category = PostgresContext.Set<Category>();
            return filter == null
                ? await category.ToListAsync()
                : await category.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Category>> GetByCategoryIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
