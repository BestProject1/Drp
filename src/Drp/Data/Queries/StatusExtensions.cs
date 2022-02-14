using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class StatusExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.Status GetByKey(this IQueryable<Drp.Data.Entities.Status> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Status> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.Status> GetByKeyAsync(this IQueryable<Drp.Data.Entities.Status> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Status> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.Status>(task);
        }

        #endregion

    }
}
