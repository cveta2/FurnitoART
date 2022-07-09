using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class AddedDataForOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "DeletedAt", "OrderNumber", "Phone", "UpdatedAt", "UserId" },
                values: new object[] { 1, "Address 1", "CIty 1", "Country 1", new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(6613), null, 1168679, 666665522, null, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(4755));

            //migrationBuilder.InsertData(
            //    table: "Roles",
            //    columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
            //    values: new object[,]
            //    {
            //        { 2, new DateTime(2022, 5, 31, 18, 40, 31, 151, DateTimeKind.Local).AddTicks(758), null, "Admin", null },
            //        { 1, new DateTime(2022, 5, 31, 18, 40, 31, 146, DateTimeKind.Local).AddTicks(4878), null, "User", null }
            //    });

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 153, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 151, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 152, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "OrderId", "ProductId", "Quantity", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 5, 31, 18, 40, 31, 155, DateTimeKind.Local).AddTicks(5173), null, false, 1, 1, 2, null });

            //migrationBuilder.InsertData(
            //    table: "RoleUseCases",
            //    columns: new[] { "RoleId", "UseCaseId" },
            //    values: new object[,]
            //    {
            //        { 1, 1 },
            //        { 1, 2 },
            //        { 2, 1 },
            //        { 2, 2 }
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 190, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 189, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 183, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 16, 25, 13, 188, DateTimeKind.Local).AddTicks(930));
        }
    }
}
