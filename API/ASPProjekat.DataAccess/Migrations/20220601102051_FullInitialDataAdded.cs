using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class FullInitialDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 2 });

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
                columns: new[] { "CreatedAt", "Description", "ProductName" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8767), "Made of solid wood with fine details and a smooth surface, the Andreson coffee table brings a classic charm to your room.", "Andreson coffee table" });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "ProductName", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, 14, new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8895), null, " Description for jaku dinning chair", "Jaku dining chair", null },
                    { 9, 14, new DateTime(2022, 6, 1, 12, 20, 50, 5, DateTimeKind.Local).AddTicks(8906), null, "Fransoa double bed is so comfortable that you will want to stay in it as long as possible every morning", "Fransoa double bed", null }
                });

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "RoleId", "UseCaseId" },
                values: new object[,]
                {
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 }
                });

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
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(2912), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7490), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7516), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7523), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7529), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 12, 20, 50, 4, DateTimeKind.Local).AddTicks(7541), "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 239, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(6146), 1316863 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProductName" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4810), "Made of solid wood with fine details and a smooth surface, the Andreson set of coffee tables brings a classic charm to your room.", "Andreson coffee tables" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "RoleId", "UseCaseId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 228, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 236, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 236, DateTimeKind.Local).AddTicks(7695), "password" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2272), "password" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2300), "password" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2307), "password" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2313), "password" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2324), "password" });
        }
    }
}
