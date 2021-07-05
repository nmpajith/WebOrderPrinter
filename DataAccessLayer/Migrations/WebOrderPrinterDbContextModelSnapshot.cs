﻿// <auto-generated />
using System;
using DataAccessLayer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(WebOrderPrinterDbContext))]
    partial class WebOrderPrinterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("DeviceDetails");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            BranchId = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kitchen Device"
                        },
                        new
                        {
                            Id = 101,
                            BranchId = 101,
                            DateCreated = new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Home Device"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceDetailId")
                        .HasColumnType("int");

                    b.Property<int>("DeviceStatusTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceDetailId")
                        .IsUnique();

                    b.HasIndex("DeviceStatusTypeId")
                        .IsUnique();

                    b.ToTable("DeviceStatuses");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceDetailId = 100,
                            DeviceStatusTypeId = 100
                        },
                        new
                        {
                            Id = 101,
                            DateCreated = new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceDetailId = 101,
                            DeviceStatusTypeId = 101
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceStatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceStatusTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("DeviceStatusType");

                    b.HasKey("Id");

                    b.ToTable("DeviceStatusTypes");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            DeviceStatusTypeName = "DeviceOnline"
                        },
                        new
                        {
                            Id = 101,
                            DeviceStatusTypeName = "DeviceOffline"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Notifications.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceDetailId")
                        .HasColumnType("int");

                    b.Property<int>("NotificationTypeId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DeviceDetailId");

                    b.HasIndex("NotificationTypeId")
                        .IsUnique();

                    b.HasIndex("OrderDetailId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            BranchId = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceDetailId = 100,
                            NotificationTypeId = 100,
                            OrderDetailId = 100
                        },
                        new
                        {
                            Id = 101,
                            BranchId = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceDetailId = 101,
                            NotificationTypeId = 101,
                            OrderDetailId = 101
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Notifications.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NotificationTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NotificationType");

                    b.HasKey("Id");

                    b.ToTable("NotificationTypes");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Message = "Failed To Validate Order",
                            NotificationTypeName = "OrderValidationFailed"
                        },
                        new
                        {
                            Id = 101,
                            Message = "Device is offline or Not responding",
                            NotificationTypeName = "DeviceOffline"
                        },
                        new
                        {
                            Id = 102,
                            Message = "Printer may be switched off. Failed to print the order",
                            NotificationTypeName = "PrintingFailed"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerOrderId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            BranchId = 0,
                            CustomerOrderId = "1050",
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = "Item1, Item2, Item3, Item4"
                        },
                        new
                        {
                            Id = 101,
                            BranchId = 0,
                            CustomerOrderId = "1051",
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = "Item5,Item6,Item7,Item8"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailId")
                        .IsUnique();

                    b.HasIndex("OrderStatusTypeId")
                        .IsUnique();

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDetailId = 0,
                            OrderStatusTypeId = 100
                        },
                        new
                        {
                            Id = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDetailId = 0,
                            OrderStatusTypeId = 101
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderStatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OrderStatusTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("OrderStatusType");

                    b.HasKey("Id");

                    b.ToTable("OrderStatusTypes");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Message = "Failed To Validate Order",
                            OrderStatusTypeName = "OrderValidationFailed"
                        },
                        new
                        {
                            Id = 101,
                            Message = "Order is recived by the device",
                            OrderStatusTypeName = "ReceivedByTheDevice"
                        },
                        new
                        {
                            Id = 102,
                            Message = "Device is found offline",
                            OrderStatusTypeName = "DeviceOffline"
                        },
                        new
                        {
                            Id = 103,
                            Message = "Order validated successfully",
                            OrderStatusTypeName = "OrderValidated"
                        },
                        new
                        {
                            Id = 104,
                            Message = "Order printed successfully",
                            OrderStatusTypeName = "PrintedSuccessfully"
                        },
                        new
                        {
                            Id = 105,
                            Message = "Failed to print the order",
                            OrderStatusTypeName = "PrintingFailed"
                        },
                        new
                        {
                            Id = 106,
                            Message = "Order sent to the device",
                            OrderStatusTypeName = "SentToDevice"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Address1 = "Address one abc",
                            Address2 = "Address two abc",
                            BranchId = 100,
                            City = "City abc",
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "1236549872",
                            State = "State abc",
                            Zipcode = "19955"
                        },
                        new
                        {
                            Id = 101,
                            Address1 = "Address one pqr",
                            Address2 = "Address two pqr",
                            BranchId = 101,
                            City = "City pqr",
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "5436549872",
                            State = "State pqr",
                            Zipcode = "14587"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "The Chill Restaurant",
                            RestaurantId = 100
                        },
                        new
                        {
                            Id = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trimo Chinese Restaurant",
                            RestaurantId = 101
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            BranchId = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "abc@abc.com",
                            FirstName = "FirstNameABC",
                            LastName = "LastNameABC",
                            MiddleName = "MiddleNameABC",
                            PhoneNumber = "1236549872"
                        },
                        new
                        {
                            Id = 101,
                            BranchId = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pqr@pqr.com",
                            FirstName = "FirstNamePQR",
                            LastName = "LastNamePQR",
                            MiddleName = "MiddleNamePQR",
                            PhoneNumber = "5436549872"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("PermissionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.HasIndex("PermissionTypeId")
                        .IsUnique();

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            ContactId = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionTypeId = 100
                        },
                        new
                        {
                            Id = 101,
                            ContactId = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionTypeId = 101
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.PermissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PermissionTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("PermissionType");

                    b.HasKey("Id");

                    b.ToTable("PermissionTypes");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            PermissionTypeName = "Admin"
                        },
                        new
                        {
                            Id = 101,
                            PermissionTypeName = "Moderator"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            DateCreated = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "The Chill Restaurant"
                        },
                        new
                        {
                            Id = 101,
                            DateCreated = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trimo Chinese Restaurant"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceDetail", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Branch", "Branch")
                        .WithMany("DeviceDetails")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceStatus", b =>
                {
                    b.HasOne("Infrastructure.Models.Device.DeviceDetail", "DeviceDetail")
                        .WithOne("DeviceStatus")
                        .HasForeignKey("Infrastructure.Models.Device.DeviceStatus", "DeviceDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Device.DeviceStatusType", "DeviceStatusType")
                        .WithOne("DeviceStatus")
                        .HasForeignKey("Infrastructure.Models.Device.DeviceStatus", "DeviceStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceDetail");

                    b.Navigation("DeviceStatusType");
                });

            modelBuilder.Entity("Infrastructure.Models.Notifications.Notification", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Branch", "Branch")
                        .WithMany("Notifications")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Device.DeviceDetail", "DeviceDetail")
                        .WithMany("Notifications")
                        .HasForeignKey("DeviceDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Notifications.NotificationType", "NotificationType")
                        .WithOne("Notification")
                        .HasForeignKey("Infrastructure.Models.Notifications.Notification", "NotificationTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Order.OrderDetail", "OrderDetail")
                        .WithMany("Notifications")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("DeviceDetail");

                    b.Navigation("NotificationType");

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderDetail", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderStatus", b =>
                {
                    b.HasOne("Infrastructure.Models.Order.OrderDetail", "OrderDetail")
                        .WithOne("OrderStatus")
                        .HasForeignKey("Infrastructure.Models.Order.OrderStatus", "OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Order.OrderStatusType", "OrderStatusType")
                        .WithOne("OrderStatus")
                        .HasForeignKey("Infrastructure.Models.Order.OrderStatus", "OrderStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetail");

                    b.Navigation("OrderStatusType");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Address", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Branch", "Branch")
                        .WithOne("Address")
                        .HasForeignKey("Infrastructure.Models.Restaurant.Address", "BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Branch", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Restaurant", "Restaurant")
                        .WithMany("Branches")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Contact", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Branch", "Branch")
                        .WithMany("Contacts")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Permission", b =>
                {
                    b.HasOne("Infrastructure.Models.Restaurant.Contact", "Contact")
                        .WithOne("Permission")
                        .HasForeignKey("Infrastructure.Models.Restaurant.Permission", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Restaurant.PermissionType", "PermissionType")
                        .WithOne("Permission")
                        .HasForeignKey("Infrastructure.Models.Restaurant.Permission", "PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("PermissionType");
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceDetail", b =>
                {
                    b.Navigation("DeviceStatus");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("Infrastructure.Models.Device.DeviceStatusType", b =>
                {
                    b.Navigation("DeviceStatus");
                });

            modelBuilder.Entity("Infrastructure.Models.Notifications.NotificationType", b =>
                {
                    b.Navigation("Notification");
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderDetail", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Infrastructure.Models.Order.OrderStatusType", b =>
                {
                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Branch", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Contacts");

                    b.Navigation("DeviceDetails");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Contact", b =>
                {
                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.PermissionType", b =>
                {
                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Infrastructure.Models.Restaurant.Restaurant", b =>
                {
                    b.Navigation("Branches");
                });
#pragma warning restore 612, 618
        }
    }
}
