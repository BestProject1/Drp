using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class TaskExtendedExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.TaskExtended GetByKey(this IQueryable<Drp.Data.Entities.TaskExtended> queryable, Guid taskId)
        {
            if (queryable is DbSet<Drp.Data.Entities.TaskExtended> dbSet)
                return dbSet.Find(taskId);

            return queryable.FirstOrDefault(q => q.TaskId == taskId);
        }

        public static ValueTask<Drp.Data.Entities.TaskExtended> GetByKeyAsync(this IQueryable<Drp.Data.Entities.TaskExtended> queryable, Guid taskId)
        {
            if (queryable is DbSet<Drp.Data.Entities.TaskExtended> dbSet)
                return dbSet.FindAsync(taskId);

            var task = queryable.FirstOrDefaultAsync(q => q.TaskId == taskId);
            return new ValueTask<Drp.Data.Entities.TaskExtended>(task);
        }

        #endregion

    }
}
