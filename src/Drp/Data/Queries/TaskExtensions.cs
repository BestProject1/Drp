using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class TaskExtensions
    {
        #region Generated Extensions
        public static IQueryable<Drp.Data.Entities.Task> ByAssignedId(this IQueryable<Drp.Data.Entities.Task> queryable, Guid? assignedId)
        {
            return queryable.Where(q => (q.AssignedId == assignedId || (assignedId == null && q.AssignedId == null)));
        }

        public static Drp.Data.Entities.Task GetByKey(this IQueryable<Drp.Data.Entities.Task> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Task> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.Task> GetByKeyAsync(this IQueryable<Drp.Data.Entities.Task> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Task> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.Task>(task);
        }

        public static IQueryable<Drp.Data.Entities.Task> ByPriorityId(this IQueryable<Drp.Data.Entities.Task> queryable, Guid? priorityId)
        {
            return queryable.Where(q => (q.PriorityId == priorityId || (priorityId == null && q.PriorityId == null)));
        }

        public static IQueryable<Drp.Data.Entities.Task> ByStatusId(this IQueryable<Drp.Data.Entities.Task> queryable, Guid statusId)
        {
            return queryable.Where(q => q.StatusId == statusId);
        }

        #endregion

    }
}
