using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using static CookingTrickery.Infrastructure.Data.Common.IngredientTypeEnum;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            //IngredientTypeConversion(builder);
            builder.HasData(IngredientSeed());
        }

        //private void IngredientTypeConversion(EntityTypeBuilder<Ingredient> builder)
        //{
        //    builder
        //        .Property(i => i.Type)
        //        .HasConversion(
        //            t => t.ToString(),
        //            t => (IngredientTypeEnum)Enum.Parse(typeof(IngredientTypeEnum), t)
        //            );
        //}

        private List<Ingredient> IngredientSeed()
        {
            var ingredients = new List<Ingredient>()
            {
                new Ingredient()
                {
                    Id = new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"),
                    Name = "Onion",
                    ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/the-health-benefits-of-onions-main-image-700-350-8425535.jpg?quality=90&webp=true&resize=300,272",
                    Type = Vegitable,
                    Calories = 40,
                    Description = "An onion , also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium.",
                    Origin = "Central Asia"
                },
                new Ingredient()
                {
                    Id = new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                    Name = "Olive Oil",
                    ImageUrl = "https://europa.eu/food-match-japan/sites/default/files/2019-11/gen-content-bloc_1272x720_olive-oil-part-of-healthy_1139661885.jpg",
                    Type = Oil,
                    Calories = 384,
                    Description = "Olive oil is a liquid fat obtained from olives (the fruit of Olea europaea; family Oleaceae), a traditional tree crop of the Mediterranean Basin.",
                    Origin = "Ancient Greek"
                },
                new Ingredient()
                {
                    Id = new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                    Name = "Carrot",
                    ImageUrl = "https://europa.eu/food-match-japan/sites/default/files/2019-11/gen-content-bloc_1272x720_olive-oil-part-of-healthy_1139661885.jpg",
                    Type = Vegitable,
                    Calories = 41,
                    Description = "The carrot (Daucus carota subsp. sativus) is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist",
                    Origin = "Central Asia"
                },
                new Ingredient()
                {
                    Id = new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                    Name = "Garlic",
                    ImageUrl = "https://5.imimg.com/data5/SELLER/Default/2020/11/ZY/NB/EM/66520044/single-clove-garlic-500x500.jpg",
                    Type = Vegitable,
                    Calories = 149,
                    Description = "Garlic (Allium sativum) is a species of bulbous flowering plant in the genus Allium. Its close relatives include the onion, shallot, leek, chive,",
                    Origin = "Middle East"
                },
                new Ingredient()
                {
                    Id = new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                    Name = "Potato",
                    ImageUrl = "https://www.alimentarium.org/sites/default/files/media/image/2017-02/AL027-01_pomme_de_terre_0_0.jpg",
                    Type = Vegitable,
                    Calories = 77,
                    Description = "The potato is a starchy tuber of the plant Solanum tuberosum and is a root vegetable native to the Americas.",
                    Origin = "South America"
                },
                new Ingredient()
                {
                    Id = new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                    Name = "Beef",
                    ImageUrl = "https://cdn.britannica.com/68/143268-050-917048EA/Beef-loin.jpg",
                    Type = Meat,
                    Calories = 250,
                    Description = "Beef is the culinary name for meat from cattle (Bos taurus).In prehistoric times, humankind hunted aurochs and later domesticated them.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.Parse("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                    Name = "Beef broth",
                    ImageUrl = "https://www.recipetineats.com/wp-content/uploads/2021/02/Homemade-Beef-Stock_1.jpg?resize=650,910",
                    Type = Broth,
                    Calories = 100,
                    Description = "Beef broth is usually the liquid meat is cooked in, sometimes with added vegetables.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("39af066a-8e5b-4942-bd68-932714284d66"),
                    Name = "Worcestershire sauce",
                    ImageUrl = "https://www.thespruceeats.com/thmb/d6Tzgm4-oztmI9RZqt_VQXM2jhc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/worcestershire-sauce-ingredients-1808089-bc73c8213ae34262bb0f01ce03fbb806.jpg",
                    Type = Sause,
                    Calories = 78,
                    Description = "Worcestershire sauce, sometimes called Worcester sauce, is a fermented liquid condiment invented in the city of Worcester in Worcestershire, England, during the first half of the 19th century.",
                    Origin = "United Kingdom"
                },
                new Ingredient()
                {
                    Id = new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                    Name = "Tomato paste",
                    ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2022/07/Homemade-Tomato-Paste-683x1024.jpg",
                    Type = Paste,
                    Calories = 82,
                    Description = "Tomato paste is a thick paste made by cooking tomatoes for several hours to reduce the water content, straining out the seeds and skins, and cooking the liquid again to reduce the base to a thick, rich concentrate.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("551e0516-e39a-4359-8211-d97e4152abcc"),
                    Name = "Dried thyme",
                    ImageUrl = "https://www.spicejungle.com/media/catalog/product/cache/77bee113a8ac4baedd074d0e50f9761e/t/h/thymemacro_2.jpg",
                    Type = Spice,
                    Calories = 1,
                    Description = "Thyme has always been a considered a plant that could grant courage. ",
                    Origin = "Mediterranean region"
                },
                new Ingredient()
                {
                    Id = new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                    Name = "Dried rosemary",
                    ImageUrl = "https://www.forestwholefoods.co.uk/wp-content/uploads/2017/04/Organic-Dried-Rosemary-1500px.jpg",
                    Type = Spice,
                    Calories = 1,
                    Description = "Though originally from Europe and the Mediterranean, many Americans see it as a classic and patriotic spice.",
                    Origin = "Europe"
                },
                new Ingredient()
                {
                    Id = new Guid("e1e685ec-4798-4ee4-97b9-c3df854461bc"),
                    Name = "Caraway seeds",
                    ImageUrl = "https://www.nutrition-and-you.com/image-files/xcaraway-seed-300x300.jpg.pagespeed.ic.jXLVdeaHWl.jpg",
                    Type = Spice,
                    Calories = 1,
                    Description = "Caraway, also known as meridian fennel and Persian cumin (Carum carvi), is a biennial plant in the family Apiaceae, native to western Asia, Europe, and North Africa",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.Parse("e61604a4-9f1e-45db-b840-b82e7327cd28"),
                    Name = "Bay leaves",
                    ImageUrl = "https://images.healthshots.com/healthshots/en/uploads/2021/06/25172258/health-benefits-of-bay-leaf.jpg",
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
                    ImageUrl = "https://pediaa.com/wp-content/uploads/2014/11/What-is-All-Purpose-Flour-01.jpg",
                    Calories = 1,
                    Description = "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = new Guid("52a20631-47f3-45c7-a1fe-a41802908375"),
                    Name = "Fresh Parsley",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0458/5780/0360/products/eumundi-farm-fresh-parsley_720x.jpg?v=1647373473",
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
