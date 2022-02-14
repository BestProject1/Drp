using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class UserLoginExtensions
    {
        #region Generated Extensions
        public static IQueryable<Drp.Data.Entities.UserLogin> ByEmailAddress(this IQueryable<Drp.Data.Entities.UserLogin> queryable, string emailAddress)
        {
            return queryable.Where(q => q.EmailAddress == emailAddress);
        }

        public static Drp.Data.Entities.UserLogin GetByKey(this IQueryable<Drp.Data.Entities.UserLogin> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.UserLogin> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.UserLogin> GetByKeyAsync(this IQueryable<Drp.Data.Entities.UserLogin> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.UserLogin> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.UserLogin>(task);
        }

        public static IQueryable<Drp.Data.Entities.UserLogin> ByUserId(this IQueryable<Drp.Data.Entities.UserLogin> queryable, Guid? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        #endregion

    }
}
