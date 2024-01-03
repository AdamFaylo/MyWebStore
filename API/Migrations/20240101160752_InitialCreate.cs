using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LogoImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogoImage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartQuantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ShippingAddressID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ShippingAddress_ShippingAddressID",
                        column: x => x.ShippingAddressID,
                        principalTable: "ShippingAddress",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Color_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GalleryImage_Product_ID",
                        column: x => x.ID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sizes_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payment_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Shoes" },
                    { 2, "Garments" },
                    { 3, "Accessories" },
                    { 4, "Shoes" },
                    { 5, "Garments" },
                    { 6, "Accessories" },
                    { 7, "Shoes" },
                    { 8, "Garments" },
                    { 9, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "FirstName", "LastName", "Mail" },
                values: new object[,]
                {
                    { 1, "Adam", "Faylo", "ed.mil.86@gmail.com" },
                    { 2, "Ray", "Faylo", "ray.faylo@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Man" },
                    { 2, "Ladies" },
                    { 3, "Kids" }
                });

            migrationBuilder.InsertData(
                table: "LogoImage",
                columns: new[] { "ID", "Alt", "Logo" },
                values: new object[] { 1, "Logo vanes site", "https://i.imgur.com/6jdrLVk.png" });

            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "ID", "Address", "City", "Country", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 1, "Nahal oz", "NewYork", "Israel", "51819", "Center" },
                    { 2, "Baryehoda", "Hollywood", "Israel", "51819", "Center" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "EmailAddress", "FirstName", "LastLogin", "LastName", "Password", "Type", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin@gmail.com", "Adam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faylo", "12345678", 999, "adam" },
                    { 2, "User@gmail.com", "Eran", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BenDahan", "87654321", 0, "eran" },
                    { 3, "roman@gmail.com", "Roman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco", "55555555", 1, "rom" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartId", "CartQuantity", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "ID", "CategoryID", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "Sneakers" },
                    { 2, 2, "T-Shirts" },
                    { 3, 2, "Pants" },
                    { 4, 3, "ACC" },
                    { 5, 4, "Sneakers" },
                    { 6, 5, "T-Shirts" },
                    { 7, 5, "Pants" },
                    { 8, 6, "ACC" },
                    { 9, 7, "Sneakers" },
                    { 10, 8, "T-Shirts" },
                    { 11, 8, "Pants" },
                    { 12, 9, "ACC" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CartId", "CustomerID", "IsPaid", "OrderDate", "ShippingAddressID", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 1, true, new DateTime(2023, 12, 31, 18, 7, 51, 954, DateTimeKind.Local).AddTicks(6727), 1, null },
                    { 2, 2, 2, false, new DateTime(2023, 12, 30, 18, 7, 51, 954, DateTimeKind.Local).AddTicks(6768), 2, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "DepartmentID", "Description", "Price", "ProductName", "SubCategoryID" },
                values: new object[,]
                {
                    { 1, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 299.90m, "Sneakers001", 1 },
                    { 2, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 359.90m, "Sneakers002", 1 },
                    { 3, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 59.90m, "Sneakers003", 1 },
                    { 4, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 89.90m, "T-Shirts001", 2 },
                    { 5, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts002", 2 },
                    { 6, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts003", 2 },
                    { 7, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants001", 3 },
                    { 8, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants002", 3 },
                    { 9, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants003", 3 },
                    { 10, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 299.90m, "ACC001", 4 },
                    { 11, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 59.90m, "ACC002", 4 },
                    { 12, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 89.90m, "ACC003", 4 },
                    { 13, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 299.90m, "Sneakers001", 5 },
                    { 14, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 359.90m, "Sneakers002", 5 },
                    { 15, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 59.90m, "Sneakers003", 5 },
                    { 16, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 89.90m, "T-Shirts001", 6 },
                    { 17, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts002", 6 },
                    { 18, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts003", 6 },
                    { 19, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants001", 7 },
                    { 20, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants002", 7 },
                    { 21, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "Pants003", 7 },
                    { 22, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "ACC", 8 },
                    { 23, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "ACC", 8 },
                    { 24, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "ACC", 8 },
                    { 25, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 299.90m, "Sneakers001", 9 },
                    { 26, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 359.90m, "Sneakers002", 9 },
                    { 27, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 59.90m, "Sneakers003", 9 },
                    { 28, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 89.90m, "T-Shirts001", 10 },
                    { 29, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts002", 10 },
                    { 30, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 29.90m, "T-Shirts003", 10 },
                    { 31, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 299.90m, "ACC001", 12 },
                    { 32, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 59.90m, "ACC002", 12 },
                    { 33, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing ", 89.90m, "ACC003", 12 }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "ID", "Name", "ProductID" },
                values: new object[,]
                {
                    { 1, "White", 1 },
                    { 2, "Black", 2 },
                    { 3, "Blue", 2 }
                });

            migrationBuilder.InsertData(
                table: "GalleryImage",
                columns: new[] { "ID", "Alt", "ImageURL", "ProductID", "Title" },
                values: new object[,]
                {
                    { 1, "man", "https://i.imgur.com/kFFe4rc.png", 1, "shoes for man" },
                    { 2, "man", "https://i.imgur.com/FSzo30R.png", 2, "shoes for man" },
                    { 3, "man", "https://i.imgur.com/OrJ3uxz.png", 3, "shoes for man" },
                    { 4, "man", "https://i.imgur.com/FMyHAER.png", 4, "T-SHIRTS for man" },
                    { 5, "man", "https://i.imgur.com/1vvkkun.png", 5, "T-SHIRTS for man" },
                    { 6, "man", "https://i.imgur.com/Q2Omp1q.png", 6, "T-SHIRTS for man" },
                    { 7, "man", "https://i.imgur.com/oPlSrbz.jpg", 7, "trousers for man" },
                    { 8, "man", "https://i.imgur.com/0oZ7MrE.jpg", 8, "trousers for man" },
                    { 9, "man", "https://i.imgur.com/UczdMkv.jpg", 9, "trousers for man" },
                    { 10, "man", "https://i.imgur.com/qpalZ7J.jpg", 10, "acc for man" },
                    { 11, "man", "https://i.imgur.com/Qd0hKEe.jpg", 11, "acc for man" },
                    { 12, "man", "https://i.imgur.com/vPXZfwu.jpg", 12, "acc for man" },
                    { 13, "woman_shoes", "https://i.imgur.com/HpT7xCj.png", 13, "shoes pastel color for woman" },
                    { 14, "woman_shoes", "https://i.imgur.com/48fArMF.png", 14, "shoes pink for woman" },
                    { 15, "woman_shoes", "https://i.imgur.com/SuXlbYo.png", 15, "shoes pink for woman" },
                    { 16, "woman", "https://i.imgur.com/nA84c5Y.png", 16, "T-SHIRT for woman" },
                    { 17, "woman", "https://i.imgur.com/KLI84On.png", 17, "T-SHIRT for woman" },
                    { 18, "woman", "https://i.imgur.com/N3Hw655.png", 18, "T-SHIRT for woman" },
                    { 19, "woman_trousers", "https://i.imgur.com/NhR4kFB.jpg", 19, "trousers for woman" },
                    { 20, "woman_trousers", "https://i.imgur.com/4xStoKp.jpg", 20, "trousers for woman" },
                    { 21, "woman_trousers", "https://i.imgur.com/n3TMOZI.jpg", 21, "trousers for woman" },
                    { 22, "woman_acc", "https://i.imgur.com/KuAG5Ae.jpg", 22, "acc for woman" },
                    { 23, "woman_acc", "https://i.imgur.com/5Mp82QF.jpg", 23, "acc for woman" },
                    { 24, "woman_acc", "https://i.imgur.com/VvOHI60.jpg", 24, "acc for woman" },
                    { 25, "kids", "https://i.imgur.com/wylMcYn.png", 25, "shoes for kids" },
                    { 26, "kids", "https://i.imgur.com/ydaUz58.png", 26, "shoes for kids" },
                    { 27, "kids", "https://i.imgur.com/WeiJljO.png", 27, "shoes for kids" },
                    { 28, "kids", "https://i.imgur.com/pBhxbGl.png", 28, "T-SHIRT for kids" },
                    { 29, "kids", "https://i.imgur.com/UJeZ4jX.png", 29, "T-SHIRT for kids" },
                    { 30, "kids", "https://i.imgur.com/pBhxbGl.png", 30, "T-SHIRT for kids" },
                    { 31, "kids", "https://i.imgur.com/5sEKFeH.png", 31, "acc for kids" },
                    { 32, "kids", "https://i.imgur.com/iaP5xXB.png", 32, "acc for kids" },
                    { 33, "kids", "https://i.imgur.com/BxlFtRr.png", 33, "acc for kids" }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "ID", "CartID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "ID", "Amount", "OrderID", "PaymentDate" },
                values: new object[,]
                {
                    { 1, 29.90m, 1, new DateTime(2023, 12, 31, 16, 7, 51, 954, DateTimeKind.Utc).AddTicks(6670) },
                    { 2, 39.90m, 2, new DateTime(2023, 12, 30, 16, 7, 51, 954, DateTimeKind.Utc).AddTicks(6677) }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "ProductID", "SizeName" },
                values: new object[,]
                {
                    { 1, 1, "XS" },
                    { 2, 2, "S" },
                    { 3, 3, "M" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Color_ProductID",
                table: "Color",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CartID",
                table: "OrderItem",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressID",
                table: "Orders",
                column: "ShippingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderID",
                table: "Payment",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_DepartmentID",
                table: "Product",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryID",
                table: "Product",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_ProductID",
                table: "Sizes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryID",
                table: "SubCategory",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "GalleryImage");

            migrationBuilder.DropTable(
                name: "LogoImage");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
