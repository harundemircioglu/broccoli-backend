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
    public class WeightsTrackingRepository : Repository<WeightsTracking, int>, IWeightsTrackingRepository
    {
        public WeightsTrackingRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<WeightsTracking>> GetAllAsync(Expression<Func<WeightsTracking, bool>>? filter = null)
        {
            var weightsTracking = PostgresContext.Set<WeightsTracking>()
                .Include(p => p.User);
            return filter == null
                ? await weightsTracking.ToListAsync()
                : await weightsTracking.Where(filter)
                .ToListAsync();
        }

        public Task<IList<WeightsTracking>> GetByWeightsTrackingIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
