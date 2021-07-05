using Infrastructure.Models.Device;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts.ContextExtentions
{
    public static class DeviceStatusModelCreation
    {
        public static void CreateDeviceStatuses(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatus>().ToTable("DeviceStatuses");
            builder.Entity<DeviceStatus>().HasKey(devstatus => devstatus.Id);
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceStatusTypeId).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceDetailId).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DateCreated).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DateModified).IsRequired(); 
            //builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceDetail).IsRequired();
            //builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceStatusType).IsRequired();
           
        }

        public static void SeedDeviceStatuses(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatus>().HasData
            (
                new DeviceStatus 
                { 
                    Id = 100, 
                    DeviceStatusTypeId = 100, 
                    DeviceDetailId = 100, 
                    DateCreated = DateTime.Parse("2021-05-16"), 
                    DateModified = DateTime.Parse("2021-06-16") 
                },
                new DeviceStatus 
                { 
                    Id = 101, 
                    DeviceStatusTypeId = 101, 
                    DeviceDetailId = 101, 
                    DateCreated = DateTime.Parse("2021-05-17"), 
                    DateModified = DateTime.Parse("2021-06-17") 
                }
            );
        }
    }
}
