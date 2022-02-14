using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class RoleExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.Role GetByKey(this IQueryable<Drp.Data.Entities.Role> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Role> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.Role> GetByKeyAsync(this IQueryable<Drp.Data.Entities.Role> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.Role> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.Role>(task);
        }

        public static Drp.Data.Entities.Role GetByName(this IQueryable<Drp.Data.Entities.Role> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<Drp.Data.Entities.Role> GetByNameAsync(this IQueryable<Drp.Data.Entities.Role> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}
