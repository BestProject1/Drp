using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class UserRoleExtensions
    {
        #region Generated Extensions
        public static IQueryable<Drp.Data.Entities.UserRole> ByRoleId(this IQueryable<Drp.Data.Entities.UserRole> queryable, Guid roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        public static IQueryable<Drp.Data.Entities.UserRole> ByUserId(this IQueryable<Drp.Data.Entities.UserRole> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static Drp.Data.Entities.UserRole GetByKey(this IQueryable<Drp.Data.Entities.UserRole> queryable, Guid userId, Guid roleId)
        {
            if (queryable is DbSet<Drp.Data.Entities.UserRole> dbSet)
                return dbSet.Find(userId, roleId);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.RoleId == roleId);
        }

        public static ValueTask<Drp.Data.Entities.UserRole> GetByKeyAsync(this IQueryable<Drp.Data.Entities.UserRole> queryable, Guid userId, Guid roleId)
        {
            if (queryable is DbSet<Drp.Data.Entities.UserRole> dbSet)
                return dbSet.FindAsync(userId, roleId);

            var task = queryable.FirstOrDefaultAsync(q => q.UserId == userId
                && q.RoleId == roleId);
            return new ValueTask<Drp.Data.Entities.UserRole>(task);
        }

        #endregion

    }
}
