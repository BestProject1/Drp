using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class AuditExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.Audit GetByKey(this IQueryable<Drp.Data.Entities.Audit> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Audit> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.Audit> GetByKeyAsync(this IQueryable<Drp.Data.Entities.Audit> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Audit> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.Audit>(task);
        }

        #endregion

    }
}
