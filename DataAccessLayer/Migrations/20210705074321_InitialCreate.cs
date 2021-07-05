using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceStatusType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceDetails_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerOrderId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionTypeId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceStatusTypeId = table.Column<int>(type: "int", nullable: false),
                    DeviceDetailId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceStatuses_DeviceDetails_DeviceDetailId",
                        column: x => x.DeviceDetailId,
                        principalTable: "DeviceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceStatuses_DeviceStatusTypes_DeviceStatusTypeId",
                        column: x => x.DeviceStatusTypeId,
                        principalTable: "DeviceStatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeviceDetailId = table.Column<int>(type: "int", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_DeviceDetails_DeviceDetailId",
                        column: x => x.DeviceDetailId,
                        principalTable: "DeviceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "NotificationTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusTypeId = table.Column<int>(type: "int", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderStatuses_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderStatuses_OrderStatusTypes_OrderStatusTypeId",
                        column: x => x.OrderStatusTypeId,
                        principalTable: "OrderStatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DeviceStatusTypes",
                columns: new[] { "Id", "DeviceStatusType" },
                values: new object[,]
                {
                    { 100, "DeviceOnline" },
                    { 101, "DeviceOffline" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "Id", "Message", "NotificationType" },
                values: new object[,]
                {
                    { 100, "Failed To Validate Order", "OrderValidationFailed" },
                    { 101, "Device is offline or Not responding", "DeviceOffline" },
                    { 102, "Printer may be switched off. Failed to print the order", "PrintingFailed" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "BranchId", "CustomerOrderId", "DateCreated", "DateModified", "Order" },
                values: new object[,]
                {
                    { 100, 0, "1050", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Item1, Item2, Item3, Item4" },
                    { 101, 0, "1051", new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Item5,Item6,Item7,Item8" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatusTypes",
                columns: new[] { "Id", "Message", "OrderStatusType" },
                values: new object[,]
                {
                    { 106, "Order sent to the device", "SentToDevice" },
                    { 105, "Failed to print the order", "PrintingFailed" },
                    { 104, "Order printed successfully", "PrintedSuccessfully" },
                    { 101, "Order is recived by the device", "ReceivedByTheDevice" },
                    { 102, "Device is found offline", "DeviceOffline" },
                    { 100, "Failed To Validate Order", "OrderValidationFailed" },
                    { 103, "Order validated successfully", "OrderValidated" }
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "PermissionType" },
                values: new object[,]
                {
                    { 100, "Admin" },
                    { 101, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chill Restaurant" },
                    { 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trimo Chinese Restaurant" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chill Restaurant", 100 },
                    { 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trimo Chinese Restaurant", 101 }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "DateCreated", "DateModified", "OrderDetailId", "OrderStatusTypeId" },
                values: new object[,]
                {
                    { 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 100 },
                    { 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 101 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address1", "Address2", "BranchId", "City", "DateCreated", "DateModified", "PhoneNumber", "State", "Zipcode" },
                values: new object[,]
                {
                    { 100, "Address one abc", "Address two abc", 100, "City abc", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "1236549872", "State abc", "19955" },
                    { 101, "Address one pqr", "Address two pqr", 101, "City pqr", new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "5436549872", "State pqr", "14587" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BranchId", "DateCreated", "DateModified", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc@abc.com", "FirstNameABC", "LastNameABC", "MiddleNameABC", "1236549872" },
                    { 101, 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "pqr@pqr.com", "FirstNamePQR", "LastNamePQR", "MiddleNamePQR", "5436549872" }
                });

            migrationBuilder.InsertData(
                table: "DeviceDetails",
                columns: new[] { "Id", "BranchId", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitchen Device" },
                    { 101, 101, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home Device" }
                });

            migrationBuilder.InsertData(
                table: "DeviceStatuses",
                columns: new[] { "Id", "DateCreated", "DateModified", "DeviceDetailId", "DeviceStatusTypeId" },
                values: new object[,]
                {
                    { 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 100 },
                    { 101, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 101 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "BranchId", "DateCreated", "DateModified", "DeviceDetailId", "NotificationTypeId", "OrderDetailId" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 100, 100 },
                    { 101, 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 101, 101 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ContactId", "DateCreated", "DateModified", "PermissionTypeId" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 101, 101, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BranchId",
                table: "Addresses",
                column: "BranchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_RestaurantId",
                table: "Branches",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchId",
                table: "Contacts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDetails_BranchId",
                table: "DeviceDetails",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatuses_DeviceDetailId",
                table: "DeviceStatuses",
                column: "DeviceDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatuses_DeviceStatusTypeId",
                table: "DeviceStatuses",
                column: "DeviceStatusTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_BranchId",
                table: "Notifications",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_DeviceDetailId",
                table: "Notifications",
                column: "DeviceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeId",
                table: "Notifications",
                column: "NotificationTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_OrderDetailId",
                table: "Notifications",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BranchId",
                table: "OrderDetails",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_OrderDetailId",
                table: "OrderStatuses",
                column: "OrderDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_OrderStatusTypeId",
                table: "OrderStatuses",
                column: "OrderStatusTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ContactId",
                table: "Permissions",
                column: "ContactId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "DeviceStatuses");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "DeviceStatusTypes");

            migrationBuilder.DropTable(
                name: "DeviceDetails");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderStatusTypes");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PermissionTypes");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
