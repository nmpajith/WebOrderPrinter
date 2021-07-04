using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class PermissionTypeModelCreation
    {
        public static void CreatePermissionTypes(this ModelBuilder builder)
        {
            builder.Entity<PermissionType>().ToTable("PermissionTypes");
            builder.Entity<PermissionType>().HasKey(pt => pt.Id);
            builder.Entity<PermissionType>().Property(pt => pt.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<PermissionType>().Property(e => e.PermissionTypeName).HasConversion<string>().HasColumnName("PermissionType")
                .IsRequired().HasMaxLength(30);
            builder.Entity<PermissionType>().HasOne<Permission>(pt => pt.Permission).WithOne(p => p.PermissionType)
                .HasForeignKey<Permission>(p => p.PermissionTypeId);
        }

        public static void SeedPermissionTypes(this ModelBuilder builder)
        {
            builder.Entity<PermissionType>().HasData
            (
                new PermissionType
                {
                    Id = 100,
                    PermissionTypeName = EPermissionTypeNames.Admin
                },
                new PermissionType
                {
                    Id = 101,
                    PermissionTypeName = EPermissionTypeNames.Moderator
                }
            );
        }
    }
}
