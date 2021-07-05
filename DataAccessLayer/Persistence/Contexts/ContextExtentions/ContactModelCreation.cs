using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class ContactModelCreation
    {
        public static void CreateContacts(this ModelBuilder builder)
        {
            builder.Entity<Contact>().ToTable("Contacts");
            builder.Entity<Contact>().HasKey(contact => contact.Id);
            builder.Entity<Contact>().Property(contact => contact.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Contact>().Property(contact => contact.FirstName).IsRequired().HasMaxLength(255);
            builder.Entity<Contact>().Property(contact => contact.MiddleName).IsRequired(false).HasMaxLength(255);
            builder.Entity<Contact>().Property(contact => contact.LastName).IsRequired(false).HasMaxLength(255);
            builder.Entity<Contact>().Property(contact => contact.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Entity<Contact>().Property(contact => contact.Email).IsRequired().HasMaxLength(255);           
            builder.Entity<Contact>().Property(contact => contact.DateCreated).IsRequired();
            builder.Entity<Contact>().Property(contact => contact.DateModified).IsRequired();
            builder.Entity<Contact>().HasOne<Permission>(contact => contact.Permission).WithOne(permission => permission.Contact)
                .HasForeignKey<Permission>(permission => permission.ContactId);
        }

        public static void SeedContacts(this ModelBuilder builder)
        {
            builder.Entity<Contact>().HasData
            (
                new Contact
                {
                    Id = 100,
                    FirstName = "FirstNameABC",
                    LastName = "LastNameABC",
                    MiddleName = "MiddleNameABC",
                    Email = "abc@abc.com",
                    PhoneNumber = "1236549872",
                    DateCreated = DateTime.Parse("2021-05-16"),
                    DateModified = DateTime.Parse("2021-05-16"),
                    BranchId = 100
                },
                new Contact
                {
                    Id = 101,
                    FirstName = "FirstNamePQR",
                    LastName = "LastNamePQR",
                    MiddleName = "MiddleNamePQR",
                    Email = "pqr@pqr.com",
                    PhoneNumber = "5436549872",
                    DateCreated = DateTime.Parse("2021-06-16"),
                    DateModified = DateTime.Parse("2021-06-16"),
                    BranchId = 101
                }
            );
        }
    }
}
