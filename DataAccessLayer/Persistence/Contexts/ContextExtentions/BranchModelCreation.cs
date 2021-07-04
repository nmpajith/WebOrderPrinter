using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class BranchModelCreation
    {
        public static void CreateBranches(this ModelBuilder builder)
        {
            builder.Entity<Branch>().ToTable("Branches");
            builder.Entity<Branch>().HasKey(branch => branch.Id);
            builder.Entity<Branch>().Property(branch => branch.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Branch>().Property(branch => branch.Name).IsRequired().HasMaxLength(255);
            builder.Entity<Branch>().Property(branch => branch.DateCreated).IsRequired();
            builder.Entity<Branch>().Property(branch => branch.DateModified).IsRequired();
            builder.Entity<Branch>().HasMany(branch => branch.Contacts).WithOne(contact => contact.Branch)
                .HasForeignKey(contact => contact.BranchId);
            builder.Entity<Branch>().HasMany(branch => branch.Notifications).WithOne(notification => notification.Branch)
                .HasForeignKey(notification => notification.BranchId);
            builder.Entity<Branch>().HasMany(branch => branch.DeviceDetails).WithOne(device => device.Branch)
                .HasForeignKey(device => device.BranchId);
            builder.Entity<Branch>().HasOne<Address>(branch => branch.Address).WithOne(ad => ad.Branch)
                .HasForeignKey<Address>(ad => ad.BranchId);
        }

        public static void SeedBranches(this ModelBuilder builder)
        {
            builder.Entity<Branch>().HasData
            (
                new Branch
                {
                    Id = 100,
                    Name = "The Chill Restaurant",
                    DateCreated = DateTime.Parse("20210516"),
                    DateModified = DateTime.Parse("20210516"),
                    RestaurantId = 100
                },
                new Branch
                {
                    Id = 101,
                    Name = "Trimo Chinese Restaurant",
                    DateCreated = DateTime.Parse("20210616"),
                    DateModified = DateTime.Parse("20210616"),
                    RestaurantId = 101
                }
            );
        }
    }
}
