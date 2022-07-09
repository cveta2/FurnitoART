using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class FullInitialDataAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductSpecifications",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "ProductId", "Quantity", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 1, 12, 29, 13, 715, DateTimeKind.Local).AddTicks(3348), null, false, 3, 3, null, 6 },
                    { 2, new DateTime(2022, 6, 1, 12, 29, 13, 715, DateTimeKind.Local).AddTicks(3406), null, false, 5, 6, null, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Alt", "CreatedAt", "DeletedAt", "Path", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Image for product 1", new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(7364), null, "image.jpg", 1, null },
                    { 3, "Image for product 3", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(14), null, "image.jpg", 3, null },
                    { 2, "Image for product 2", new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(9989), null, "image.jpg", 2, null },
                    { 4, "Image for product 4", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(19), null, "image.jpg", 4, null },
                    { 5, "Image for product 5", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(24), null, "image.jpg", 5, null },
                    { 6, "Image for product 6", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(34), null, "image.jpg", 6, null },
                    { 7, "Image for product 7", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(40), null, "image.jpg", 7, null },
                    { 8, "Image for product 8", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(45), null, "image.jpg", 8, null },
                    { 9, "Image for product 9", new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(49), null, "image.jpg", 9, null }
                });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 29, 13, 714, DateTimeKind.Local).AddTicks(1331), 5485027 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "PriceValue", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(4548), null, false, 90.99m, 1, null },
                    { 9, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6521), null, false, 355.99m, 9, null },
                    { 8, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6515), null, false, 62.99m, 8, null },
                    { 7, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6509), null, false, 230.99m, 7, null },
                    { 6, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6503), null, false, 132.99m, 6, null },
                    { 2, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6454), null, false, 85.99m, 2, null },
                    { 4, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6487), null, false, 275.99m, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "PriceValue", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6480), null, false, 156.99m, 3, null },
                    { 5, new DateTime(2022, 6, 1, 12, 29, 13, 713, DateTimeKind.Local).AddTicks(6494), null, false, 350.99m, 5, null }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "ProductId", "SpecificationId", "SpecificationValue" },
                values: new object[,]
                {
                    { 1, 1, 1, "55cm" },
                    { 8, 3, 3, "95cm" },
                    { 2, 1, 3, "90cm" },
                    { 9, 3, 2, "50cm" },
                    { 4, 2, 1, "40cm" },
                    { 10, 4, 1, "80cm" },
                    { 11, 4, 3, "180cm" },
                    { 12, 4, 2, "75cm" },
                    { 13, 5, 1, "900cm" },
                    { 14, 5, 3, "180cm" },
                    { 15, 5, 2, "75cm" },
                    { 16, 6, 1, "80cm" },
                    { 17, 6, 2, "150cm" },
                    { 19, 9, 1, "160cm" },
                    { 20, 9, 3, "200cm" },
                    { 21, 9, 2, "45cm" },
                    { 7, 3, 1, "60cm" },
                    { 6, 2, 2, "45cm" },
                    { 3, 1, 2, "45cm" },
                    { 5, 2, 3, "50cm" },
                    { 18, 6, 1, "30cm" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 706, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 710, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 712, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 29, 13, 711, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductSpecifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications",
                columns: new[] { "ProductId", "SpecificationId" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 8, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 7, DateTimeKind.Local).AddTicks(6088), 6701244 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 49, 999, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 3, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7541));
        }
    }
}
