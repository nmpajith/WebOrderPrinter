using BusinessLogicLayer.Models.Devices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class DeviceDetailModelCreation
    {
        public static void CreateDeviceDetails(this ModelBuilder builder)
        {
            builder.Entity<DeviceDetail>().ToTable("DeviceDetails");
            builder.Entity<DeviceDetail>().HasKey(devdetail => devdetail.Id);
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.Name).IsRequired().HasMaxLength(255);
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.BranchId).IsRequired();
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.DateCreated).IsRequired();
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.DateModified).IsRequired();
            builder.Entity<DeviceDetail>().Property(devdetail => devdetail.Branch).IsRequired();

        }

        public static void SeedDeviceDetails(this ModelBuilder builder)
        {
            builder.Entity<DeviceDetail>().HasData
            (
                new DeviceDetail { Id = 100, Name = "Kitchen Device", BranchId = 101, DateCreated = DateTime.Parse("20210516"), DateModified = DateTime.Parse("20210616") },
                new DeviceDetail { Id = 101, Name = "Home Device", BranchId = 102, DateCreated = DateTime.Parse("20210518"), DateModified = DateTime.Parse("20210618") }
            );
        }
    }
}
