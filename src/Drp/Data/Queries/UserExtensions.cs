using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Queries
{
    public static partial class UserExtensions
    {
        #region Generated Extensions
        public static Drp.Data.Entities.User GetByEmailAddress(this IQueryable<Drp.Data.Entities.User> queryable, string emailAddress)
        {
            return queryable.FirstOrDefault(q => q.EmailAddress == emailAddress);
        }

        public static Task<Drp.Data.Entities.User> GetByEmailAddressAsync(this IQueryable<Drp.Data.Entities.User> queryable, string emailAddress)
        {
            return queryable.FirstOrDefaultAsync(q => q.EmailAddress == emailAddress);
        }

        public static Drp.Data.Entities.User GetByKey(this IQueryable<Drp.Data.Entities.User> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.User> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Drp.Data.Entities.User> GetByKeyAsync(this IQueryable<Drp.Data.Entities.User> queryable, Guid id)
        {
            if (queryable is DbSet<Drp.Data.Entities.User> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Drp.Data.Entities.User>(task);
        }

        #endregion

    }
}
