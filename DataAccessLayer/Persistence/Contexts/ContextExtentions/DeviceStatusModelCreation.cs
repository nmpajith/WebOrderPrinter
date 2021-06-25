﻿using BusinessLogicLayer.Models.Devices;
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
        public static void CreateDeviceStatus(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatus>().ToTable("DeviceStatuses");
            builder.Entity<DeviceStatus>().HasKey(devstatus => devstatus.Id);
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceStatusTypeId).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceDetailTypeId).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DateCreated).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DateModified).IsRequired(); 
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceDetails).IsRequired();
            builder.Entity<DeviceStatus>().Property(devstatus => devstatus.DeviceStatusTypes).IsRequired();
           
        }

        public static void SeedDeviceStatus(this ModelBuilder builder)
        {
            builder.Entity<DeviceStatus>().HasData
            (
                new DeviceStatus { Id = 100, DeviceStatusTypeId = 101, DeviceDetailTypeId = 101, DateCreated = DateTime.Parse("20210516"), DateModified = DateTime.Parse("20210616") },
                new DeviceStatus { Id = 101, DeviceStatusTypeId = 102, DeviceDetailTypeId = 102, DateCreated = DateTime.Parse("20210517"), DateModified = DateTime.Parse("20210617") }
            );
        }
    }
}
