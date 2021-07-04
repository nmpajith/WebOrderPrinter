using Infrastructure.Models.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class OrderDetailModelCreation
    {
        public static void CreateOrderDetail(this ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().ToTable("OrderDetails");
            builder.Entity<OrderDetail>().HasKey(order => order.Id);
            builder.Entity<OrderDetail>().Property(order => order.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<OrderDetail>().Property(order => order.CustomerOrderId).IsRequired().HasMaxLength(30);
            builder.Entity<OrderDetail>().Property(order => order.Order).IsRequired().HasMaxLength(255);
            builder.Entity<OrderDetail>().Property(order => order.DateCreated).IsRequired();
            builder.Entity<OrderDetail>().Property(order => order.DateModified).IsRequired();
            builder.Entity<OrderDetail>().HasMany(order => order.Notifications).WithOne(notification => notification.OrderDetail)
                .HasForeignKey(notification => notification.OrderDetailId);
            builder.Entity<OrderDetail>().HasOne<OrderStatus>(order => order.OrderStatus).WithOne(os => os.OrderDetail)
                .HasForeignKey<OrderStatus>(os => os.OrderDetailId);
        }

        public static void SeedOrderDetail(this ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().HasData
            (
                new OrderDetail
                {
                    Id = 100,
                    CustomerOrderId = "1050",
                    DateCreated = DateTime.Parse("20210516"),
                    DateModified = DateTime.Parse("20210516"),
                    Order = "Item1, Item2, Item3, Item4"
                },
                new OrderDetail
                {
                    Id = 101,
                    CustomerOrderId = "1051",
                    DateCreated = DateTime.Parse("20210616"),
                    DateModified = DateTime.Parse("20210616"),
                    Order = "Item5,Item6,Item7,Item8"
                }
            );
        }
    }
}
