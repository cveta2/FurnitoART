using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class AddedConfigurationForCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 44, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 44, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 2, 17, 48, 30, 43, DateTimeKind.Local).AddTicks(2229), 5548338 });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 42, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 31, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 39, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 41, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 48, 30, 40, DateTimeKind.Local).AddTicks(8333));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Carts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 852, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 852, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 852, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(6251), 3272941 });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 851, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 845, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 849, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 849, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 17, 39, 27, 850, DateTimeKind.Local).AddTicks(616));
        }
    }
}
