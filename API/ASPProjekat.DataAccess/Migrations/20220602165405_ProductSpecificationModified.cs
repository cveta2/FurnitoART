using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class ProductSpecificationModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Products_ProductId",
                table: "Prices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductSpecifications",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 2, 18, 54, 2, 863, DateTimeKind.Local).AddTicks(1787), 2193614 });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 855, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 860, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 862, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 2, 18, 54, 2, 861, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Products_ProductId",
                table: "Prices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Products_ProductId",
                table: "Prices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductSpecifications");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Products_ProductId",
                table: "Prices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
