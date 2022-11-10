using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class CuisineIngredientPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cuisines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4518b84b-107b-4a44-8c46-8811a2c4959e", "AQAAAAEAACcQAAAAEDVB1JqSloAvzdxHwdxcKBl02Yk6Ldl0fjzq/y/Z5PPPYAzwoV/H1ei/jtuVOKuXJg==", "8d8bd737-ec3d-4b5d-8609-8c0ea5b5d871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ddba27-d7c0-496a-b9c0-0a52f6cc82b3", "AQAAAAEAACcQAAAAEOZl56I75LhqUleb/4ihrA/m74VxU7oxXzclztgFLyi46OPLt77wQBmUIH2ISAiYhA==", "ad5d2ac4-9a35-4777-b355-848babeff6ed" });

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("a6521833-8514-4d09-b7c0-9ee03373ffc5"),
                column: "ImageUrl",
                value: "https://i-winereview.com/blog/wp-content/uploads/2018/05/Header-BulgariaFood-1.jpg");

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("b0de4591-35bc-4500-b84f-ee04c64775ea"),
                column: "ImageUrl",
                value: "https://images.squarespace-cdn.com/content/v1/53b839afe4b07ea978436183/1619636932396-6DZZR1WGINWYADFUCU9I/popular-food-in-mexico.jpg?format=1000w");

            migrationBuilder.UpdateData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"),
                column: "ImageUrl",
                value: "https://fullsuitcase.com/wp-content/uploads/2021/01/Traditional-British-food.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                column: "ImageUrl",
                value: "https://europa.eu/food-match-japan/sites/default/files/2019-11/gen-content-bloc_1272x720_olive-oil-part-of-healthy_1139661885.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                column: "ImageUrl",
                value: "https://www.preciouscore.com/wp-content/uploads/2022/07/Homemade-Tomato-Paste-683x1024.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                column: "ImageUrl",
                value: "https://cdn.britannica.com/68/143268-050-917048EA/Beef-loin.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("39af066a-8e5b-4942-bd68-932714284d66"),
                column: "ImageUrl",
                value: "https://www.thespruceeats.com/thmb/d6Tzgm4-oztmI9RZqt_VQXM2jhc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/worcestershire-sauce-ingredients-1808089-bc73c8213ae34262bb0f01ce03fbb806.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                column: "ImageUrl",
                value: "https://www.forestwholefoods.co.uk/wp-content/uploads/2017/04/Organic-Dried-Rosemary-1500px.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"),
                column: "ImageUrl",
                value: "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/the-health-benefits-of-onions-main-image-700-350-8425535.jpg?quality=90&webp=true&resize=300,272");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                column: "ImageUrl",
                value: "https://www.alimentarium.org/sites/default/files/media/image/2017-02/AL027-01_pomme_de_terre_0_0.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                column: "ImageUrl",
                value: "https://cdn.shopify.com/s/files/1/0458/5780/0360/products/eumundi-farm-fresh-parsley_720x.jpg?v=1647373473");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("551e0516-e39a-4359-8211-d97e4152abcc"),
                column: "ImageUrl",
                value: "https://www.spicejungle.com/media/catalog/product/cache/77bee113a8ac4baedd074d0e50f9761e/t/h/thymemacro_2.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"),
                column: "ImageUrl",
                value: "https://pediaa.com/wp-content/uploads/2014/11/What-is-All-Purpose-Flour-01.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                column: "ImageUrl",
                value: "https://europa.eu/food-match-japan/sites/default/files/2019-11/gen-content-bloc_1272x720_olive-oil-part-of-healthy_1139661885.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                column: "ImageUrl",
                value: "https://5.imimg.com/data5/SELLER/Default/2020/11/ZY/NB/EM/66520044/single-clove-garlic-500x500.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                column: "ImageUrl",
                value: "https://www.recipetineats.com/wp-content/uploads/2021/02/Homemade-Beef-Stock_1.jpg?resize=650,910");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e1e685ec-4798-4ee4-97b9-c3df854461bc"),
                column: "ImageUrl",
                value: "https://www.nutrition-and-you.com/image-files/xcaraway-seed-300x300.jpg.pagespeed.ic.jXLVdeaHWl.jpg");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e61604a4-9f1e-45db-b840-b82e7327cd28"),
                column: "ImageUrl",
                value: "https://images.healthshots.com/healthshots/en/uploads/2021/06/25172258/health-benefits-of-bay-leaf.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 19, 37, 4, 511, DateTimeKind.Local).AddTicks(4982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cuisines");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e37d294c-b340-4e4f-b86f-278d52a56cd2", "AQAAAAEAACcQAAAAELyjQsAdax6M2KaZYk2T6Mz4pEq888umNOFXL7u6Dva+JvptaFwtWWxCJ3bhqyPE3Q==", "48756312-5c2e-473b-8f07-f06ae2226099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a10289f9-5be2-493f-bfaf-d5eed90809a6", "AQAAAAEAACcQAAAAEIVFu4CY/qbnsVrRzsUeYtI7S4AVNLuvpDQt64uv6aqDTp2QJn8N7pVR3+XklrvtSQ==", "a3513ee8-d93c-4536-88b4-a12078a8eb81" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 8, 19, 28, 27, 759, DateTimeKind.Local).AddTicks(9875));
        }
    }
}
