using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Drp.Data.Mapping
{
    public partial class SystemMenuMap
        : IEntityTypeConfiguration<Drp.Data.Entities.SystemMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Drp.Data.Entities.SystemMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SystemMenu", "dbo");

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

            builder.Property(t => t.ParentId)
                .IsRequired()
                .HasColumnName("ParentId")
                .HasColumnType("bigint");

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Ico)
                .HasColumnName("Ico")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Url)
                .HasColumnName("Url")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.OrderRule)
                .HasColumnName("OrderRule")
                .HasColumnType("int");

            builder.Property(t => t.Level)
                .HasColumnName("Level")
                .HasColumnType("int");

            builder.Property(t => t.Class)
                .HasColumnName("Class")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SystemMenu";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string DataChangeLastTime = "DataChangeLastTime";
            public const string IsActive = "IsActive";
            public const string ParentId = "ParentId";
            public const string Name = "Name";
            public const string Ico = "Ico";
            public const string Url = "Url";
            public const string OrderRule = "OrderRule";
            public const string Level = "Level";
            public const string Class = "Class";
        }
        #endregion
    }
}
