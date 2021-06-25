using BusinessLogicLayer.Models.Devices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class DeviceStatusTypeModelCreation
    {
        public static void CreateDeviceStatusTypes(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatusType>().ToTable("DeviceStatusTypes");
            builder.Entity<DeviceStatusType>().HasKey(devstatustype => devstatustype.Id);
            builder.Entity<DeviceStatusType>().Property(devstatustype => devstatustype.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DeviceStatusType>().Property(devstatustype => devstatustype.Name).IsRequired().HasMaxLength(255);
        }

        public static void SeedDeviceStatusTypes(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatusType>().HasData
            (
                new DeviceStatusType { Id = 100, Name = "Device Online" },
                new DeviceStatusType { Id = 101, Name = "Device Offline" }
            );
        }
    }
}
