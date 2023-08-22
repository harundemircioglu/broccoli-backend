using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        Task<IList<Category>> GetByCategoryIdAsync(int id);
    }
}
