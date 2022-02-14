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
        public virtual DbSet<Drp.Data.Entities.Audit> Audits { get; set; }

        public virtual DbSet<Drp.Data.Entities.Priority> Priorities { get; set; }

        public virtual DbSet<Drp.Data.Entities.Role> Roles { get; set; }

        public virtual DbSet<Drp.Data.Entities.Status> Statuses { get; set; }

        public virtual DbSet<Drp.Data.Entities.TaskExtended> TaskExtendeds { get; set; }

        public virtual DbSet<Drp.Data.Entities.Task> Tasks { get; set; }

        public virtual DbSet<Drp.Data.Entities.UserLogin> UserLogins { get; set; }

        public virtual DbSet<Drp.Data.Entities.UserRole> UserRoles { get; set; }

        public virtual DbSet<Drp.Data.Entities.User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.AuditMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.PriorityMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.RoleMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.StatusMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.TaskExtendedMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.TaskMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.UserLoginMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.UserMap());
            modelBuilder.ApplyConfiguration(new Drp.Data.Mapping.UserRoleMap());
            #endregion
        }
    }
}
