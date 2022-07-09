using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseCaseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAuthorized = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccuredAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleUseCases",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UseCaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUseCases", x => new { x.RoleId, x.UseCaseId });
                    table.ForeignKey(
                        name: "FK_RoleUseCases_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SpecificationValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => new { x.ProductId, x.SpecificationId });
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_UseCaseName",
                table: "AuditLogs",
                column: "UseCaseName");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderNumber",
                table: "Orders",
                column: "OrderNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ProductId",
                table: "Prices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_SpecificationId",
                table: "ProductSpecifications",
                column: "SpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_FirstName",
                table: "Users",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LastName",
                table: "Users",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");



            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "ParentCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Table", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(2682), null, null, null },
                    { 2, "Bed", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(5584), null, null, null },
                    { 3, "Chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(5632), null, null, null },
                    { 4, "Decoration", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(6916), null, null, null },
                    { 19, "Wardrobe", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7463), null, null, null },
                    { 20, "Shelf", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7472), null, null, null }
                });

            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "ParentCategoryId", "UpdatedAt" },
               values: new object[,]
               {
                    { 5, "Dining table", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7276), null, 1, null },
                    { 6, "Coffee table", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7326), null, 1, null },
                    { 7, "Desk", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7336), null, 1, null },
                    { 8, "Computer table", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7346), null, 1, null },
                    { 9, "Single bed", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7356), null, 2, null },
                    { 10, "Duble bed", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7370), null, 2, null },
                    { 11, "Sofa", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7382), null, 2, null },
                    { 12, "Two-seater", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7393), null, 2, null },
                    { 13, "Three-seater", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7403), null, 2, null },
                    { 14, "Dining chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7413), null, 3, null },
                    { 15, "Computer chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7423), null, 3, null },
                    { 16, "Office chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7434), null, 3, null },
                    { 17, "Children's chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7442), null, 3, null },
                    { 18, "Garden chair", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7454), null, 3, null },
                    { 21, "Bookshelf", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7482), null, 20, null },
                    { 22, "Wall shelf", new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7493), null, 20, null }
               });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7024), null, "User", null },
                    { 2, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7013), null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "RoleId", "UseCaseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                });

            migrationBuilder.InsertData(
                table: "Specifications",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "SpecificationName", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7024), null, "Color", null },
                    { 4, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7013), null, "Depth", null },
                    { 3, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7000), null, "Length", null },
                    { 2, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(6963), null, "Height", null },
                    { 1, new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(5193), null, "Width", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "Password", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 31, 16, 25, 13, 183, DateTimeKind.Local).AddTicks(1632), null, "johnsmith@gmail.com", "John", "Smith", "password", 1, null },
                    { 2, new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(832), null, "mikelegend@gmail.com", "Mike", "Legend", "password", 1, null },
                    { 3, new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(898), null, "mariajameson@gmail.com", "Maria", "Jameson", "password", 1, null },
                    { 4, new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(908), null, "juliawilliams@gmail.com", "Julia", "Williams", "password", 1, null },
                    { 5, new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(914), null, "micheleroberts@gmail.com", "Michele", "Roberts", "password", 1, null },
                    { 6, new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(930), null, "anastasija@gmail.com", "Anastasija", "Jokovic", "password", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "ProductName", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 5, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6656), null, "Haku is dining table for 6 persons. As gold and glass are erfect match, we are sure that this table will be perfect in any type of home.", "Haku dining table", null },
                    { 5, 5, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6663), null, "Mora is dining table for 4 persons. ", "Mora dining table", null },
                    { 1, 6, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(3530), null, "This coffee table with glass surface will elevate the look of your space. It is perfect for luxury homes.", "Cheney coffee table", null },
                    { 2, 6, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6620), null, "Golden details on this table makes it look really refinedand we are sure that this is the right choice if you are looking for something simple yet effective.", "Aula coffee table", null },
                    { 3, 6, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6649), null, "Made of solid wood with fine details and a smooth surface, the Andreson set of coffee tables brings a classic charm to your room.", "Andreson coffee tables", null },
                    { 7, 16, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6683), null, "Adjust the height and angle of this chair to make you comfortable during the working day. The mesh backrest leaks air, so you won't heat the chair even when the workload increases.", "Markus office chair", null },
                    { 6, 21, new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6677), null, "White bookshelf gives you so much freedom to decorate it in any way you like! You can store books, magazines or any type of decoration pieces.", "Marcel bookshelf", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ExceptionLogs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "RoleUseCases");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
