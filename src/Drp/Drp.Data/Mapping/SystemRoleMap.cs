using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Mapping
{
    public partial class SystemRoleMap
        : IEntityTypeConfiguration<Drp.Data.Entities.SystemRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Drp.Data.Entities.SystemRole> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SystemRole", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DataChangeLastTime)
                .IsRequired()
                .HasColumnName("DataChangeLastTime")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.MenuRights)
                .HasColumnName("MenuRights")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.ActionList)
                .HasColumnName("ActionList")
                .HasColumnType("ntext");

            builder.Property(t => t.CreateUser)
                .HasColumnName("CreateUser")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreateRoleId)
                .IsRequired()
                .HasColumnName("CreateRoleId")
                .HasColumnType("bigint");

            builder.Property(t => t.RoleName)
                .HasColumnName("RoleName")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SystemRole";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string DataChangeLastTime = "DataChangeLastTime";
            public const string IsActive = "IsActive";
            public const string MenuRights = "MenuRights";
            public const string ActionList = "ActionList";
            public const string CreateUser = "CreateUser";
            public const string CreateRoleId = "CreateRoleId";
            public const string RoleName = "RoleName";
            public const string Description = "Description";
        }
        #endregion
    }
}
