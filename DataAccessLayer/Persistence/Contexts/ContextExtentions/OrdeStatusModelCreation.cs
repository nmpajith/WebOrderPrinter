using Infrastructure.Models.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class OrdeStatusModelCreation
    {
        public static void CreateOrderStatuses(this ModelBuilder builder)
        {
            builder.Entity<OrderStatus>().ToTable("OrderStatuses");
            builder.Entity<OrderStatus>().HasKey(os => os.Id);
            builder.Entity<OrderStatus>().Property(os => os.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<OrderStatus>().Property(os => os.DateCreated).IsRequired();
            builder.Entity<OrderStatus>().Property(os => os.DateModified).IsRequired();
        }

        public static void SeedOrderStatuses(this ModelBuilder builder)
        {
            builder.Entity<OrderStatus>().HasData
            (
                new OrderStatus
                {
                    Id = 100,
                    DateCreated = DateTime.Parse("2021-05-16"),
                    DateModified = DateTime.Parse("2021-05-16"),
                    OrderStatusTypeId = 100
                },
                new OrderStatus
                {
                    Id = 101,
                    DateCreated = DateTime.Parse("2021-06-16"),
                    DateModified = DateTime.Parse("2021-06-16"),
                    OrderStatusTypeId = 101
                }
            );
        }
    }
}
