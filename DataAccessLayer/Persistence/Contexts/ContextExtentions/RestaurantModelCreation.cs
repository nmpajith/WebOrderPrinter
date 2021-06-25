using BusinessLogicLayer.Models.Restaurants;
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
        public static void CreateRestaurant(this ModelBuilder builder)
        {
            builder.Entity<Restaurant>().ToTable("Categories");
            builder.Entity<Restaurant>().HasKey(rest => rest.Id);
            builder.Entity<Restaurant>().Property(rest => rest.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Restaurant>().Property(rest => rest.Name).IsRequired().HasMaxLength(255);
            builder.Entity<Restaurant>().Property(rest => rest.DateCreated).IsRequired();
            builder.Entity<Restaurant>().Property(rest => rest.DateModified).IsRequired();
            builder.Entity<Restaurant>().HasMany(rest => rest.Branches).WithOne(branch => branch.Restaurant)
                .HasForeignKey(branch => branch.RestaurantId);
        }
    }
}
