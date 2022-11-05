using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7ddb140b-f530-4f1c-90f5-9cc6761f1551"));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                column: "Description",
                value: "The carrot (Daucus carota subsp. sativus) is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                column: "Description",
                value: "Tomato paste is a thick paste made by cooking tomatoes for several hours to reduce the water content, straining out the seeds and skins, and cooking the liquid again to reduce the base to a thick, rich concentrate.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                column: "Description",
                value: "Beef is the culinary name for meat from cattle (Bos taurus).In prehistoric times, humankind hunted aurochs and later domesticated them.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("39af066a-8e5b-4942-bd68-932714284d66"),
                column: "Description",
                value: "Worcestershire sauce, sometimes called Worcester sauce, is a fermented liquid condiment invented in the city of Worcester in Worcestershire, England, during the first half of the 19th century.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                column: "Description",
                value: "Though originally from Europe and the Mediterranean, many Americans see it as a classic and patriotic spice.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"),
                column: "Description",
                value: "An onion , also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                column: "Description",
                value: "The potato is a starchy tuber of the plant Solanum tuberosum and is a root vegetable native to the Americas.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Parsley, or garden parsley (Petroselinum crispum) is a species of flowering plant in the family Apiaceae that is native to the central and eastern Mediterranean region ", 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("551e0516-e39a-4359-8211-d97e4152abcc"),
                column: "Description",
                value: "Thyme has always been a considered a plant that could grant courage. ");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"),
                column: "Description",
                value: "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                column: "Description",
                value: "Olive oil is a liquid fat obtained from olives (the fruit of Olea europaea; family Oleaceae), a traditional tree crop of the Mediterranean Basin.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                column: "Description",
                value: "Garlic (Allium sativum) is a species of bulbous flowering plant in the genus Allium. Its close relatives include the onion, shallot, leek, chive,");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                column: "Description",
                value: "Beef broth is usually the liquid meat is cooked in, sometimes with added vegetables.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e61604a4-9f1e-45db-b840-b82e7327cd28"),
                column: "Description",
                value: "The bay leaf is an aromatic leaf commonly used in cooking. It can be used whole, either dried or fresh, in which case it is removed from the dish before consumption, or less commonly used in ground form.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                column: "Description",
                value: "The carrot (Daucus carota subsp. sativus) is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist,[2][3][4] all of which are domesticated forms of the wild carrot, Daucus carota, native to Europe and Southwestern Asia. The plant probably originated in Persia and was originally cultivated for its leaves and seeds. The most commonly eaten part of the plant is the taproot, although the stems and leaves are also eaten. The domestic carrot has been selectively bred for its enlarged, more palatable, less woody-textured taproot.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                column: "Description",
                value: "Tomato paste is a thick paste made by cooking tomatoes for several hours to reduce the water content, straining out the seeds and skins, and cooking the liquid again to reduce the base to a thick, rich concentrate.[1] It is used to impart an intense tomato flavour to a variety of dishes, such as pasta, soups and braised meat. It is used heavily in Italian cultured food.By contrast, tomato purée is a liquid with a thinner consistency than tomato paste, while tomato sauce is even thinner in consistency");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                column: "Description",
                value: "Beef is the culinary name for meat from cattle (Bos taurus).In prehistoric times, humankind hunted aurochs and later domesticated them. Since that time, numerous breeds of cattle have been bred specifically for the quality or quantity of their meat. Today, beef is the third most widely consumed meat in the world, after pork and poultry. As of 2018, the United States, Brazil, and China were the largest producers of beef.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("39af066a-8e5b-4942-bd68-932714284d66"),
                column: "Description",
                value: "Worcestershire sauce, sometimes called Worcester sauce, is a fermented liquid condiment invented in the city of Worcester in Worcestershire, England, during the first half of the 19th century. The inventors were the pharmacists John Wheeley Lea and William Henry Perrins, who went on to form the company Lea & Perrins. Worcestershire sauce has been a generic term since 1876, when the English High Court of Justice ruled that Lea & Perrins did not own a trademark for the name Worcestershire.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                column: "Description",
                value: "Though originally from Europe and the Mediterranean, many Americans see it as a classic and patriotic spice. Perfect on chicken, lamb, game, beef, and pork, rosemary should always make an appearance at the dinner table for whatever holiday it is.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"),
                column: "Description",
                value: "An onion , also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium. The shallot is a botanical variety of the onion which was classified as a separate species until 2010. Its close relatives include garlic, scallion, leek, and chive.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                column: "Description",
                value: "The potato is a starchy tuber of the plant Solanum tuberosum and is a root vegetable native to the Americas. The plant is a perennial in the nightshade family Solanaceae.Wild potato species can be found from the southern United States to southern Chile.The potato was originally believed to have been domesticated by Native Americans independently in multiple locations,[4] but later genetic studies traced a single origin, in the area of present-day southern Peru and extreme northwestern Bolivia. Potatoes were domesticated there approximately 7,000–10,000 years ago, from a species in the Solanum brevicaule complex.In the Andes region of South America, where the species is indigenous, some close relatives of the potato are cultivated.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..", 13 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("551e0516-e39a-4359-8211-d97e4152abcc"),
                column: "Description",
                value: "Thyme has always been a considered a plant that could grant courage. In fact, Medieval knights often tucked it in their armor as a charm when they went to war. This practice was understandable as the Greek word “thymus”, for which the herb was named after, means courage.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"),
                column: "Description",
                value: "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                column: "Description",
                value: "Olive oil is a liquid fat obtained from olives (the fruit of Olea europaea; family Oleaceae), a traditional tree crop of the Mediterranean Basin, produced by pressing whole olives and extracting the oil. It is commonly used in cooking: for frying foods or as a salad dressing. It can be found in some cosmetics, pharmaceuticals, soaps, and fuels for traditional oil lamps. It also has additional uses in some religions. The olive is one of three core food plants in Mediterranean cuisine; the other two are wheat and grapes. Olive trees have been grown around the Mediterranean since the 8th millennium BC.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                column: "Description",
                value: "Garlic (Allium sativum) is a species of bulbous flowering plant in the genus Allium. Its close relatives include the onion, shallot, leek, chive,[2] Welsh onion and Chinese onion.[3] It is native to South Asia, Central Asia and northeastern Iran and has long been used as a seasoning worldwide, with a history of several thousand years of human consumption and use.[4][5] It was known to ancient Egyptians and has been used as both a food flavoring and a traditional medicine.[6][7] China produces 76% of the world's supply of garlic");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                column: "Description",
                value: "Beef broth is usually the liquid meat is cooked in, sometimes with added vegetables. Broth is usually seasoned with herbs and spices, and sometimes a splash of wine or acid to balance the flavors to be drinkable on its own. Beef stock is more meaty flavored than beef broth.");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e61604a4-9f1e-45db-b840-b82e7327cd28"),
                column: "Description",
                value: "The bay leaf is an aromatic leaf commonly used in cooking. It can be used whole, either dried or fresh, in which case it is removed from the dish before consumption, or less commonly used in ground form. It may come from several species of tree, the Bay laurel and the California bay tree being the most common. The flavor that a bay leaf imparts to a dish has not been universally agreed upon, but most agree it is a subtle addition.");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Calories", "Description", "Name", "Origin", "Type" },
                values: new object[] { new Guid("7ddb140b-f530-4f1c-90f5-9cc6761f1551"), 50, "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. Flours are used to make many different foods. Cereal flour, particularly wheat flour, is the main ingredient of bread, which is a staple food for many cultures. Corn flour has been important in Mesoamerican cuisine since ancient times and remains a staple in the Americas. Rye flour is a constituent of bread in central and northern Europe..", "All-purpose Flour", "All over the world", 13 });
        }
    }
}
