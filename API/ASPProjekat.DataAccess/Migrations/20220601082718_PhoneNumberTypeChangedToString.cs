using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class PhoneNumberTypeChangedToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

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
                columns: new[] { "CreatedAt", "OrderNumber", "Phone" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(6146), 1316863, "0666665522" });

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
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 238, DateTimeKind.Local).AddTicks(4810));

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
                values: new object[] { 2, 3 });

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
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 236, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 1, 10, 27, 16, 237, DateTimeKind.Local).AddTicks(2324));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Orders",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 155, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber", "Phone" },
                values: new object[] { new DateTime(2022, 5, 31, 18, 40, 31, 154, DateTimeKind.Local).AddTicks(6613), 1168679, 666665522 });

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 146, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 31, 18, 40, 31, 151, DateTimeKind.Local).AddTicks(758));

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
        }
    }
}
