using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Drp.Data
{
    public partial class DrpContext : DbContext
    {
        public DrpContext(DbContextOptions<DrpContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Drp.Data.Entities.SystemMenu> SystemMenus { get; set; }

        public virtual DbSet<Drp.Data.Entities.SystemPageAction> SystemPageActions { get; set; }

        public virtual DbSet<Drp.Data.Entities.SystemRole> SystemRoles { get; set; }

        public virtual DbSet<Drp.Data.Entities.SystemUser> SystemUsers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.SystemMenuMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.SystemPageActionMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.SystemRoleMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.SystemUserMap());
            #endregion
        }
    }
}
