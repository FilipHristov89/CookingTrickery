using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static CookingTrickery.Infrastructure.Data.Common.IngredientTypeEnum;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(IngredientSeed());
        }

        private List<Ingredient> IngredientSeed()
        {
            var ingredients = new List<Ingredient>()
            {
                new Ingredient()
                {
                    Id = new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"),
                    Name = "Onion",
                    Type = Vegitable,
                    Calories = 40,
                    Description = "An onion , also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium.",
                    Origin = "Central Asia"
                },
                new Ingredient()
                {
                    Id = new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                    Name = "Olive Oil",
                    Type = Oil,
                    Calories = 384,
                    Description = "Olive oil is a liquid fat obtained from olives (the fruit of Olea europaea; family Oleaceae), a traditional tree crop of the Mediterranean Basin.",
                    Origin = "Ancient Greek"
                },
                new Ingredient()
                {
                    Id = new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                    Name = "Carrot",
                    Type = Vegitable,
                    Calories = 41,
                    Description = "The carrot (Daucus carota subsp. sativus) is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist",
                    Origin = "Central Asia"
                },
                new Ingredient()
                {
                    Id = new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                    Name = "Garlic",
                    Type = Vegitable,
                    Calories = 149,
                    Description = "Garlic (Allium sativum) is a species of bulbous flowering plant in the genus Allium. Its close relatives include the onion, shallot, leek, chive,",
                    Origin = "Middle East"
                },
                new Ingredient()
                {
                    Id = new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                    Name = "Potato",
                    Type = Vegitable,
                    Calories = 77,
                    Description = "The potato is a starchy tuber of the plant Solanum tuberosum and is a root vegetable native to the Americas.",
                    Origin = "South America"
                },
                new Ingredient()
                {
                    Id = new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                    Name = "Beef",
                    Type = Meat,
                    Calories = 250,
                    Description = "Beef is the culinary name for meat from cattle (Bos taurus).In prehistoric times, humankind hunted aurochs and later domesticated them.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.Parse("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                    Name = "Beef broth",
                    Type = Broth,
                    Calories = 100,
                    Description = "Beef broth is usually the liquid meat is cooked in, sometimes with added vegetables.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("39af066a-8e5b-4942-bd68-932714284d66"),
                    Name = "Worcestershire sauce",
                    Type = Sause,
                    Calories = 78,
                    Description = "Worcestershire sauce, sometimes called Worcester sauce, is a fermented liquid condiment invented in the city of Worcester in Worcestershire, England, during the first half of the 19th century.",
                    Origin = "United Kingdom"
                },
                new Ingredient()
                {
                    Id = new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                    Name = "Tomato paste",
                    Type = Paste,
                    Calories = 82,
                    Description = "Tomato paste is a thick paste made by cooking tomatoes for several hours to reduce the water content, straining out the seeds and skins, and cooking the liquid again to reduce the base to a thick, rich concentrate.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("551e0516-e39a-4359-8211-d97e4152abcc"),
                    Name = "Dried thyme",
                    Type = Spice,
                    Calories = 1,
                    Description = "Thyme has always been a considered a plant that could grant courage. ",
                    Origin = "Mediterranean region"
                },
                new Ingredient()
                {
                    Id = new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                    Name = "Dried rosemary",
                    Type = Spice,
                    Calories = 1,
                    Description = "Though originally from Europe and the Mediterranean, many Americans see it as a classic and patriotic spice.",
                    Origin = "Europe"
                },
                new Ingredient()
                {
                    Id = new Guid("e1e685ec-4798-4ee4-97b9-c3df854461bc"),
                    Name = "Caraway seeds",
                    Type = Spice,
                    Calories = 1,
                    Description = "Caraway, also known as meridian fennel and Persian cumin (Carum carvi), is a biennial plant in the family Apiaceae, native to western Asia, Europe, and North Africa",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.Parse("e61604a4-9f1e-45db-b840-b82e7327cd28"),
                    Name = "Bay leaves",
                    Type = Spice,
                    Calories = 1,
                    Description = "The bay leaf is an aromatic leaf commonly used in cooking. It can be used whole, either dried or fresh, in which case it is removed from the dish before consumption, or less commonly used in ground form.",
                    Origin = "Mediterranean region"
                },
                new Ingredient()
                {
                    Id = new Guid("630c4443-28ff-4aba-a48b-6dbe6c64b033"),
                    Name = "All-purpose Flour",
                    Type = Baking_product,
                    Calories = 1,
                    Description = "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                    Name = "Fresh Parsley",
                    Type = Vegitable,
                    Calories = 5,
                    Description = "Parsley, or garden parsley (Petroselinum crispum) is a species of flowering plant in the family Apiaceae that is native to the central and eastern Mediterranean region ",
                    Origin = "Mediterranean region"
                },
            };

            return ingredients;
        }
    }
}
