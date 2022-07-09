using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPProjekat.DataAccess.Migrations
{
    public partial class newProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(1783), 7554853 });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "ProductName", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, 19, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2340), null, "Description for bourbon wardrobe", "Bourbon wardrobe", null },
                    { 11, 19, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2346), null, "Description for keaton wardrobe", "Keaton wardrobe", null },
                    { 12, 12, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2455), null, "Description for Haru two seater sofa", "Haru two seater sofa", null },
                    { 13, 12, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2464), null, "Description for Kooper two seater sofa", "Kooper two seater sofa", null },
                    { 14, 13, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2470), null, "Description for Kooper Lottie seater sofa", "Lottie three seater sofa", null },
                    { 19, 11, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2502), null, "Description for Harlow corner sofa", "Harlow corner sofa", null },
                    { 18, 9, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2496), null, "Description for Besley single bed", "Besley single bed", null },
                    { 17, 22, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2487), null, "Description for Leyla wall shelf", "Leyla wall shelf", null },
                    { 16, 4, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2482), null, "Description for Florals wall set", "Florals wall set", null },
                    { 15, 4, new DateTime(2022, 6, 25, 22, 10, 17, 585, DateTimeKind.Local).AddTicks(2476), null, "Description for Faces wall set", "Faces wall set", null }
                });

            migrationBuilder.InsertData(
                table: "RoleUseCases",
                columns: new[] { "RoleId", "UseCaseId" },
                values: new object[,]
                {
                    { 1, 15 },
                    { 1, 4 },
                    { 1, 7 },
                    { 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 575, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 583, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 25, 22, 10, 17, 584, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Alt", "CreatedAt", "DeletedAt", "Path", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, "Image for product 10", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(581), null, "bourbon-wardrobe.jpg", 10, null },
                    { 11, "Image for product 11", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(586), null, "keaton-wardrobe.jpg", 11, null },
                    { 12, "Image for product 12", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(591), null, "haru-two-seater-sofa.jpg", 12, null },
                    { 13, "Image for product 13", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(596), null, "kooper-two-seater-sofa.jpg", 13, null },
                    { 14, "Image for product 14", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(601), null, "lottie-three-seater-sofa.jpg", 14, null },
                    { 15, "Image for product 15", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(606), null, "faces-wall-set.jpg", 15, null },
                    { 16, "Image for product 16", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(611), null, "florals-wall-set.jpg", 16, null },
                    { 17, "Image for product 17", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(616), null, "leyla-wall-shelf.jpg", 17, null },
                    { 18, "Image for product 18", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(821), null, "besley-single-bed.jpg", 18, null },
                    { 19, "Image for product 19", new DateTime(2022, 6, 25, 22, 10, 17, 586, DateTimeKind.Local).AddTicks(831), null, "harlow-corner-sofa.jpg", 19, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RoleUseCases",
                keyColumns: new[] { "RoleId", "UseCaseId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 83, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 83, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "ParentCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, "Desk", new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2390), null, 1, null },
                    { 17, "Children's chair", new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2498), null, 3, null },
                    { 8, "Computer table", new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2400), null, 1, null },
                    { 18, "Garden chair", new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(2510), null, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderNumber" },
                values: new object[] { new DateTime(2022, 6, 24, 13, 31, 45, 82, DateTimeKind.Local).AddTicks(1874), 3635985 });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 81, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 74, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Specifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 80, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 24, 13, 31, 45, 79, DateTimeKind.Local).AddTicks(8865));
        }
    }
}
