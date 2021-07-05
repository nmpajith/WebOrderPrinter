using Infrastructure.Models.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class NotificationModelCreation
    {
        public static void CreateNotifications(this ModelBuilder builder)
        {
            builder.Entity<Notification>().ToTable("Notifications");
            builder.Entity<Notification>().HasKey(n => n.Id);
            builder.Entity<Notification>().Property(n => n.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Notification>().Property(n => n.DateCreated).IsRequired();
            builder.Entity<Notification>().Property(n => n.DateModified).IsRequired();
        }

        public static void SeedNotifications(this ModelBuilder builder)
        {
            builder.Entity<Notification>().HasData
            (
                new Notification
                {
                    Id = 100,
                    DateCreated = DateTime.Parse("2021-05-16"),
                    DateModified = DateTime.Parse("2021-05-16"),
                    NotificationTypeId = 100,
                    DeviceDetailId=100,
                    OrderDetailId=100,
                    BranchId=100
                },
                new Notification
                {
                    Id = 101,
                    DateCreated = DateTime.Parse("2021-06-16"),
                    DateModified = DateTime.Parse("2021-06-16"),
                    NotificationTypeId = 101,
                    DeviceDetailId = 101,
                    OrderDetailId = 101,
                    BranchId = 101
                }
            );
        }
    }
}
