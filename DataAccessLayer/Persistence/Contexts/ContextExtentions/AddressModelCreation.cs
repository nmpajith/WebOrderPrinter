using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class AddressModelCreation
    {
        public static void CreateAddresses(this ModelBuilder builder)
        {
            builder.Entity<Address>().ToTable("Addresses");
            builder.Entity<Address>().HasKey(add => add.Id);
            builder.Entity<Address>().Property(add => add.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Address>().Property(add => add.Address1).IsRequired().HasMaxLength(255);
            builder.Entity<Address>().Property(add => add.Address2).IsRequired().HasMaxLength(255);
            builder.Entity<Address>().Property(add => add.City).IsRequired().HasMaxLength(100);
            builder.Entity<Address>().Property(add => add.State).IsRequired().HasMaxLength(100);
            builder.Entity<Address>().Property(add => add.Zipcode).IsRequired().HasMaxLength(5);
            builder.Entity<Address>().Property(add => add.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Entity<Address>().Property(add => add.DateCreated).IsRequired();
            builder.Entity<Address>().Property(add => add.DateModified).IsRequired();
        }

        public static void SeedAddresses(this ModelBuilder builder)
        {
            builder.Entity<Address>().HasData
            (
                new Address
                {
                    Id = 100,
                    Address1 = "Address one abc",
                    Address2 = "Address two abc",
                    City="City abc",
                    State="State abc",
                    Zipcode="19955",
                    PhoneNumber="1236549872",
                    DateCreated = DateTime.Parse("2021-05-16"),
                    DateModified = DateTime.Parse("2021-05-16"),
                    BranchId = 100
                },
                new Address
                {
                    Id = 101,
                    Address1 = "Address one pqr",
                    Address2 = "Address two pqr",
                    City = "City pqr",
                    State = "State pqr",
                    Zipcode = "14587",
                    PhoneNumber = "5436549872",
                    DateCreated = DateTime.Parse("2021-06-16"),
                    DateModified = DateTime.Parse("2021-06-16"),
                    BranchId = 101
                }
            );
        }
    }
}
