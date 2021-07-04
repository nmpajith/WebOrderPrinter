using Infrastructure.Models.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class OrdeStatusTypeModelCreation
    {
        public static void CreateOrderStatusTypes(this ModelBuilder builder)
        {
            builder.Entity<OrderStatusType>().ToTable("OrderStatusTypes");
            builder.Entity<OrderStatusType>().HasKey(os => os.Id);
            builder.Entity<OrderStatusType>().Property(os => os.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<OrderStatusType>().Property(os => os.Message).IsRequired().HasMaxLength(255);
            builder.Entity<OrderStatusType>().Property(e => e.OrderStatusTypeName).HasConversion<string>().HasColumnName("OrderStatusType")
                .IsRequired().HasMaxLength(30);
            builder.Entity<OrderStatusType>().HasOne<OrderStatus>(ost => ost.OrderStatus).WithOne(os => os.OrderStatusType)
                .HasForeignKey<OrderStatus>(os => os.OrderStatusTypeId);
        }

        public static void SeedOrderStatusTypes(this ModelBuilder builder)
        {
            builder.Entity<OrderStatusType>().HasData
            (
                new OrderStatusType
                {
                    Id = 100,
                    Message = "Failed To Validate Order",
                    OrderStatusTypeName = EOrderStatusTypeNames.OrderValidationFailed,
                },
                new OrderStatusType
                {
                    Id = 101,
                    Message = "Order is recived by the device",
                    OrderStatusTypeName = EOrderStatusTypeNames.ReceivedByTheDevice,
                },
                new OrderStatusType
                {
                    Id = 102,
                    Message = "Device is found offline",
                    OrderStatusTypeName = EOrderStatusTypeNames.DeviceOffline,
                },
                new OrderStatusType
                {
                    Id = 103,
                    Message = "Order validated successfully",
                    OrderStatusTypeName = EOrderStatusTypeNames.OrderValidated,
                },
                new OrderStatusType
                {
                    Id = 104,
                    Message = "Order printed successfully",
                    OrderStatusTypeName = EOrderStatusTypeNames.PrintedSuccessfully,
                },
                new OrderStatusType
                {
                    Id = 105,
                    Message = "Failed to print the order",
                    OrderStatusTypeName = EOrderStatusTypeNames.PrintingFailed,
                },
                new OrderStatusType
                {
                    Id = 106,
                    Message = "Order sent to the device",
                    OrderStatusTypeName = EOrderStatusTypeNames.SentToDevice,
                }
            );
        }
    }
}
