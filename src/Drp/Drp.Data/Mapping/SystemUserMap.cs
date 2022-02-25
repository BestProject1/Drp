using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Mapping
{
    public partial class SystemUserMap
        : IEntityTypeConfiguration<Drp.Data.Entities.SystemUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Drp.Data.Entities.SystemUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SystemUser", "dbo");

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

            builder.Property(t => t.Eid)
                .HasColumnName("Eid")
                .HasColumnType("nvarchar(36)")
                .HasMaxLength(36);

            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Pwd)
                .HasColumnName("Pwd")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginIp)
                .HasColumnName("LoginIp")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MenuRights)
                .HasColumnName("MenuRights")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("bigint");

            builder.Property(t => t.LastLoginTime)
                .HasColumnName("LastLoginTime")
                .HasColumnType("datetime");

            builder.Property(t => t.UserAgent)
                .HasColumnName("UserAgent")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.CreateRoleName)
                .HasColumnName("CreateRoleName")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.CreateUser)
                .HasColumnName("CreateUser")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SystemUser";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string DataChangeLastTime = "DataChangeLastTime";
            public const string IsActive = "IsActive";
            public const string Eid = "Eid";
            public const string UserName = "UserName";
            public const string Pwd = "Pwd";
            public const string Phone = "Phone";
            public const string LoginIp = "LoginIp";
            public const string MenuRights = "MenuRights";
            public const string RoleId = "RoleId";
            public const string LastLoginTime = "LastLoginTime";
            public const string UserAgent = "UserAgent";
            public const string CreateRoleName = "CreateRoleName";
            public const string CreateUser = "CreateUser";
        }
        #endregion
    }
}
