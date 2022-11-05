using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class RecipeUserChangesAndFavoriteRecipesChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Recipes_FavoriteRecipeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FavoriteRecipeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteRecipeId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PrepTime",
                table: "Recipes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Ingredients",
                type: "int",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Calories", "Description", "Name", "Origin", "Type" },
                values: new object[,]
                {
                    { new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"), 41, "The carrot (Daucus carota subsp. sativus) is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist, all of which are domesticated forms of the wild carrot, Daucus carota, native to Europe and Southwestern Asia. The plant probably originated in Persia and was originally cultivated for its leaves and seeds. The most commonly eaten part of the plant is the taproot, although the stems and leaves are also eaten. The domestic carrot has been selectively bred for its enlarged, more palatable, less woody-textured taproot.", "Carrot", "Central Asia", 1 },
                    { new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"), 82, "Tomato paste is a thick paste made by cooking tomatoes for several hours to reduce the water content, straining out the seeds and skins, and cooking the liquid again to reduce the base to a thick, rich concentrate.[1] It is used to impart an intense tomato flavour to a variety of dishes, such as pasta, soups and braised meat. It is used heavily in Italian cultured food.By contrast, tomato purée is a liquid with a thinner consistency than tomato paste, while tomato sauce is even thinner in consistency", "Tomato paste", "All over the world", 25 },
                    { new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"), 250, "Beef is the culinary name for meat from cattle (Bos taurus).In prehistoric times, humankind hunted aurochs and later domesticated them. Since that time, numerous breeds of cattle have been bred specifically for the quality or quantity of their meat. Today, beef is the third most widely consumed meat in the world, after pork and poultry. As of 2018, the United States, Brazil, and China were the largest producers of beef.", "Beef", "All over the world", 2 },
                    { new Guid("39af066a-8e5b-4942-bd68-932714284d66"), 78, "Worcestershire sauce, sometimes called Worcester sauce, is a fermented liquid condiment invented in the city of Worcester in Worcestershire, England, during the first half of the 19th century. The inventors were the pharmacists John Wheeley Lea and William Henry Perrins, who went on to form the company Lea & Perrins. Worcestershire sauce has been a generic term since 1876, when the English High Court of Justice ruled that Lea & Perrins did not own a trademark for the name Worcestershire.", "Worcestershire sauce", "United Kingdom", 4 },
                    { new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"), 1, "Though originally from Europe and the Mediterranean, many Americans see it as a classic and patriotic spice. Perfect on chicken, lamb, game, beef, and pork, rosemary should always make an appearance at the dinner table for whatever holiday it is.", "Dried rosemary", "Europe", 11 },
                    { new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"), 40, "An onion , also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium. The shallot is a botanical variety of the onion which was classified as a separate species until 2010. Its close relatives include garlic, scallion, leek, and chive.", "Onion", "Central Asia", 1 },
                    { new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"), 77, "The potato is a starchy tuber of the plant Solanum tuberosum and is a root vegetable native to the Americas. The plant is a perennial in the nightshade family Solanaceae.Wild potato species can be found from the southern United States to southern Chile.The potato was originally believed to have been domesticated by Native Americans independently in multiple locations,[4] but later genetic studies traced a single origin, in the area of present-day southern Peru and extreme northwestern Bolivia. Potatoes were domesticated there approximately 7,000–10,000 years ago, from a species in the Solanum brevicaule complex.In the Andes region of South America, where the species is indigenous, some close relatives of the potato are cultivated.", "Potato", "South America", 1 },
                    { new Guid("52a20631-47f3-45c7-a1fe-a41802908375"), 5, "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..", "Fresh Parsley", "Mediterranean region", 13 },
                    { new Guid("551e0516-e39a-4359-8211-d97e4152abcc"), 1, "Thyme has always been a considered a plant that could grant courage. In fact, Medieval knights often tucked it in their armor as a charm when they went to war. This practice was understandable as the Greek word “thymus”, for which the herb was named after, means courage.", "Dried thyme", "Mediterranean region", 11 },
                    { new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"), 1, "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..", "All-purpose Flour", "All over the world", 13 },
                    { new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"), 384, "Olive oil is a liquid fat obtained from olives (the fruit of Olea europaea; family Oleaceae), a traditional tree crop of the Mediterranean Basin, produced by pressing whole olives and extracting the oil. It is commonly used in cooking: for frying foods or as a salad dressing. It can be found in some cosmetics, pharmaceuticals, soaps, and fuels for traditional oil lamps. It also has additional uses in some religions. The olive is one of three core food plants in Mediterranean cuisine; the other two are wheat and grapes. Olive trees have been grown around the Mediterranean since the 8th millennium BC.", "Olive Oil", "Ancient Greek", 3 },
                    { new Guid("7ddb140b-f530-4f1c-90f5-9cc6761f1551"), 50, "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..", "All-purpose Flour", "All over the world", 13 },
                    { new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"), 149, "Garlic (Allium sativum) is a species of bulbous flowering plant in the genus Allium. Its close relatives include the onion, shallot, leek, chive,[2] Welsh onion and Chinese onion.[3] It is native to South Asia, Central Asia and northeastern Iran and has long been used as a seasoning worldwide, with a history of several thousand years of human consumption and use.[4][5] It was known to ancient Egyptians and has been used as both a food flavoring and a traditional medicine.[6][7] China produces 76% of the world's supply of garlic", "Garlic", "Middle East", 1 },
                    { new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"), 100, "Beef broth is usually the liquid meat is cooked in, sometimes with added vegetables. Broth is usually seasoned with herbs and spices, and sometimes a splash of wine or acid to balance the flavors to be drinkable on its own. Beef stock is more meaty flavored than beef broth.", "Beef broth", "All over the world", 22 },
                    { new Guid("e1e685ec-4798-4ee4-97b9-c3df854461bc"), 1, "Caraway, also known as meridian fennel and Persian cumin (Carum carvi), is a biennial plant in the family Apiaceae, native to western Asia, Europe, and North Africa", "Caraway seeds", "All over the world", 11 },
                    { new Guid("e61604a4-9f1e-45db-b840-b82e7327cd28"), 1, "The bay leaf is an aromatic leaf commonly used in cooking. It can be used whole, either dried or fresh, in which case it is removed from the dish before consumption, or less commonly used in ground form. It may come from several species of tree, the Bay laurel and the California bay tree being the most common. The flavor that a bay leaf imparts to a dish has not been universally agreed upon, but most agree it is a subtle addition.", "Bay leaves", "Mediterranean region", 11 }
                });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "MeasurementType", "Quantity" },
                values: new object[,]
                {
                    { new Guid("100248f5-ce7f-40ca-abc8-c0d005c8a988"), 16, 3.0 },
                    { new Guid("1ac5b1b6-9dbb-49fc-ad95-686476a0fb57"), 12, 0.5 },
                    { new Guid("27c6be3e-3404-4525-9a05-b3b4811ad2dd"), 14, 4.0 },
                    { new Guid("451e6845-3dde-44fa-9787-37d2f12fab0b"), 4, 1.0 },
                    { new Guid("63cd695b-d2fc-42b7-9e1c-633e1dcec351"), 5, 1.0 },
                    { new Guid("717496fb-5b3c-439f-bc15-dd74381d6d7d"), 15, 2.0 },
                    { new Guid("77264a66-b4a2-4657-abf7-9db4e7b1adf9"), 5, 1.0 },
                    { new Guid("8b1d8496-58a3-405f-8bc2-036867407274"), 5, 1.0 },
                    { new Guid("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a"), 13, 3.0 },
                    { new Guid("b5a9d637-315c-416b-98f9-ee5f702833de"), 5, 1.0 },
                    { new Guid("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c"), 4, 2.0 },
                    { new Guid("c2106501-d1ce-4eb0-9c91-82a4898fcb67"), 3, 1.0 },
                    { new Guid("d45f0662-ae2e-47ce-b662-8e459b3f0e0e"), 4, 2.0 },
                    { new Guid("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd"), 3, 2.0 },
                    { new Guid("df4924db-cdc2-44f4-9ab0-b181c26c5e93"), 14, 1.0 },
                    { new Guid("fadac7a7-abb2-4e75-93f4-b42ac441bed5"), 4, 2.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("39af066a-8e5b-4942-bd68-932714284d66"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("551e0516-e39a-4359-8211-d97e4152abcc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7ddb140b-f530-4f1c-90f5-9cc6761f1551"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e1e685ec-4798-4ee4-97b9-c3df854461bc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e61604a4-9f1e-45db-b840-b82e7327cd28"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("100248f5-ce7f-40ca-abc8-c0d005c8a988"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("1ac5b1b6-9dbb-49fc-ad95-686476a0fb57"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("27c6be3e-3404-4525-9a05-b3b4811ad2dd"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("451e6845-3dde-44fa-9787-37d2f12fab0b"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("63cd695b-d2fc-42b7-9e1c-633e1dcec351"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("717496fb-5b3c-439f-bc15-dd74381d6d7d"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("77264a66-b4a2-4657-abf7-9db4e7b1adf9"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("8b1d8496-58a3-405f-8bc2-036867407274"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("b5a9d637-315c-416b-98f9-ee5f702833de"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("c2106501-d1ce-4eb0-9c91-82a4898fcb67"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("d45f0662-ae2e-47ce-b662-8e459b3f0e0e"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("df4924db-cdc2-44f4-9ab0-b181c26c5e93"));

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: new Guid("fadac7a7-abb2-4e75-93f4-b42ac441bed5"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "PrepTime",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Ingredients",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<Guid>(
                name: "FavoriteRecipeId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FavoriteRecipeId",
                table: "AspNetUsers",
                column: "FavoriteRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Recipes_FavoriteRecipeId",
                table: "AspNetUsers",
                column: "FavoriteRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
