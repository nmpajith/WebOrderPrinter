using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class RestaurantModelCreation
    {
        public static void CreateRestaurants(this ModelBuilder builder)
        {
            builder.Entity<Restaurant>().ToTable("Restaurants");
            builder.Entity<Restaurant>().HasKey(rest => rest.Id);
            builder.Entity<Restaurant>().Property(rest => rest.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Restaurant>().Property(rest => rest.Name).IsRequired().HasMaxLength(255);
            builder.Entity<Restaurant>().Property(rest => rest.DateCreated).IsRequired();
            builder.Entity<Restaurant>().Property(rest => rest.DateModified).IsRequired();
            builder.Entity<Restaurant>().HasMany(rest => rest.Branches).WithOne(branch => branch.Restaurant)
                .HasForeignKey(branch => branch.RestaurantId);
        }

        public static void SeedRestaurants(this ModelBuilder builder)
        {
            builder.Entity<Restaurant>().HasData
            (
                new Restaurant { Id = 100, Name = "The Chill Restaurant", DateCreated = DateTime.Parse("2021-05-16"), DateModified = DateTime.Parse("2021-05-16") },
                new Restaurant { Id = 101, Name = "Trimo Chinese Restaurant", DateCreated = DateTime.Parse("2021-06-16"), DateModified = DateTime.Parse("2021-06-16") }
            );
        }
    }
}
