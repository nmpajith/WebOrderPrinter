using DataAccessLayer.Persistence.Contexts.ContextExtentions;
using Infrastructure.Models.Device;
using Infrastructure.Models.Notifications;
using Infrastructure.Models.Order;
using Infrastructure.Models.Restaurant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts
{
    public class WebOrderPrinterDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderStatusType> OrderStatusTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<DeviceDetail> DeviceDetails { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        public DbSet<DeviceStatusType> DeviceStatusTypes { get; set; }

        public WebOrderPrinterDbContext(DbContextOptions<WebOrderPrinterDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.CreateRestaurants();
            builder.SeedRestaurants();
            builder.CreateBranches();
            builder.SeedBranches();
            builder.CreateAddresses();
            builder.SeedAddresses();
            builder.CreateContacts();
            builder.SeedContacts();
            builder.CreatePermissions();
            builder.SeedPermissions();
            builder.CreatePermissionTypes();
            builder.SeedPermissionTypes();
            builder.CreateOrderDetail();
            builder.SeedOrderDetail();
            builder.CreateOrderStatuses();
            builder.SeedOrderStatuses();
            builder.CreateOrderStatusTypes();
            builder.SeedOrderStatusTypes();
            builder.CreateNotifications();
            builder.SeedNotifications();
            builder.CreateNotificationTypes();
            builder.SeedNotificationTypes();
            builder.CreateDeviceStatusTypes();
            builder.SeedDeviceStatusTypes();
            builder.CreateDeviceStatuses();
            builder.SeedDeviceStatuses();
            builder.CreateDeviceDetails();
            builder.SeedDeviceDetails();
        }
    }
}
