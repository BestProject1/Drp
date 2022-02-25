using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class SystemMenuExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.SystemMenu GetByKey(this IQueryable<Drp.Data.Entities.SystemMenu> queryable, long Id)
        {
            if (queryable is DbSet<Drp.Data.Entities.SystemMenu> dbSet)
                return dbSet.Find(Id);

            return queryable.FirstOrDefault(q => q.Id == Id);
        }

        public static ValueTask<Drp.Data.Entities.SystemMenu> GetByKeyAsync(this IQueryable<Drp.Data.Entities.SystemMenu> queryable, long Id)
        {
            if (queryable is DbSet<Drp.Data.Entities.SystemMenu> dbSet)
                return dbSet.FindAsync(Id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == Id);
            return new ValueTask<Drp.Data.Entities.SystemMenu>(task);
        }

        #endregion

    }
}
