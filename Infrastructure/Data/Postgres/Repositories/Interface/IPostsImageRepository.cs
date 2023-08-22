using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IPostsImageRepository : IRepository<PostsImage, int>
    {
        Task<IList<PostsImage>> GetByPostsImageIdAsync(int id);
    }
}
