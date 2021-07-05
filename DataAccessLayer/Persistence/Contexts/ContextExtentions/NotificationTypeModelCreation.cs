using Infrastructure.Models.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class NotificationTypeModelCreation
    {
        public static void CreateNotificationTypes(this ModelBuilder builder)
        {
            builder.Entity<NotificationType>().ToTable("NotificationTypes");
            builder.Entity<NotificationType>().HasKey(nt => nt.Id);
            builder.Entity<NotificationType>().Property(nt => nt.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<NotificationType>().Property(nt => nt.Message).IsRequired().HasMaxLength(255);
            builder.Entity<NotificationType>().Property(nt => nt.NotificationTypeName).HasConversion<string>().HasColumnName("NotificationType")
                .IsRequired().HasMaxLength(30);
            builder.Entity<NotificationType>().HasOne<Notification>(nt => nt.Notification).WithOne(n => n.NotificationType)
                .HasForeignKey<Notification>(n => n.NotificationTypeId).OnDelete(DeleteBehavior.NoAction);
        }

        public static void SeedNotificationTypes(this ModelBuilder builder)
        {
            builder.Entity<NotificationType>().HasData
            (
                new NotificationType
                {
                    Id = 100,
                    Message = "Failed To Validate Order",
                    NotificationTypeName=ENotificationTypeNames.OrderValidationFailed
                },
                new NotificationType
                {
                    Id = 101,
                    Message = "Device is offline or Not responding",
                    NotificationTypeName = ENotificationTypeNames.DeviceOffline
                }
                ,
                new NotificationType
                {
                    Id = 102,
                    Message = "Printer may be switched off. Failed to print the order",
                    NotificationTypeName = ENotificationTypeNames.PrintingFailed
                }
            );
        }
    }
}
