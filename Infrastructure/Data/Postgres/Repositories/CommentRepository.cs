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
    public class CommentRepository : Repository<Comment, int>, ICommentRepository
    {
        public CommentRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Comment>> GetAllAsync(Expression<Func<Comment, bool>>? filter = null)
        {
            var comment = PostgresContext.Set<Comment>()
                .Include(p => p.User)
                .Include(p => p.Post);

            return filter == null
                ? await comment.ToListAsync()
                : await comment.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Comment>> GetByCommentIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
