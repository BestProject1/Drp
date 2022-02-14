using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class PriorityExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.Priority GetByKey(this IQueryable<Drp.Data.Entities.Priority> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Priority> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.Priority> GetByKeyAsync(this IQueryable<Drp.Data.Entities.Priority> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Priority> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.Priority>(task);
        }

        #endregion

    }
}
