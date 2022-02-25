using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Mapping
{
    public partial class SystemPageActionMap
        : IEntityTypeConfiguration<Drp.Data.Entities.SystemPageAction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Drp.Data.Entities.SystemPageAction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SystemPageAction", "dbo");

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

            builder.Property(t => t.MenuId)
                .IsRequired()
                .HasColumnName("MenuId")
                .HasColumnType("bigint");

            builder.Property(t => t.ActionId)
                .HasColumnName("ActionId")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ActionName)
                .HasColumnName("ActionName")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ControlName)
                .HasColumnName("ControlName")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SystemPageAction";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string DataChangeLastTime = "DataChangeLastTime";
            public const string MenuId = "MenuId";
            public const string ActionId = "ActionId";
            public const string ActionName = "ActionName";
            public const string ControlName = "ControlName";
        }
        #endregion
    }
}
