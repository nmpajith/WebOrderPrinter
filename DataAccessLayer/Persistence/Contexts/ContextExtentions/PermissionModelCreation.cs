using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class PermissionModelCreation
    {
        public static void CreatePermissions(this ModelBuilder builder)
        {
            builder.Entity<Permission>().ToTable("Permissions");
            builder.Entity<Permission>().HasKey(p => p.Id);
            builder.Entity<Permission>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();           
            builder.Entity<Permission>().Property(p => p.DateCreated).IsRequired();
            builder.Entity<Permission>().Property(p => p.DateModified).IsRequired();
        }

        public static void SeedPermissions(this ModelBuilder builder)
        {
            builder.Entity<Permission>().HasData
            (
                new Permission
                {
                    Id = 100,
                    DateCreated = DateTime.Parse("2021-05-16"),
                    DateModified = DateTime.Parse("2021-05-16"),
                    ContactId = 100,
                    PermissionTypeId = 100
                },
                new Permission
                {
                    Id = 101,
                    DateCreated = DateTime.Parse("2021-06-16"),
                    DateModified = DateTime.Parse("2021-06-16"),
                    PermissionTypeId = 101,
                    ContactId = 101
                }
            );
        }
    }
}
