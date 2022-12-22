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
                    Type = Herb,
                    Calories = 5,
                    Description = "Parsley, or garden parsley (Petroselinum crispum) is a species of flowering plant in the family Apiaceae that is native to the central and eastern Mediterranean region ",
                    Origin = "Mediterranean region"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Orange",
                    ImageUrl = "https://www.santosfood.com/wp-content/uploads/2020/01/img-7.jpg?1742x1295",
                    Type = Fruit,
                    Calories = 47,
                    Description = "An orange is a fruit of various citrus species in the family Rutaceae it primarily refers to Citrus × sinensis, which is also called sweet orange, to distinguish it from the related Citrus × aurantium, referred to as bitter orange.",
                    Origin = "China"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Salmon",
                    ImageUrl = "https://img.freepik.com/free-photo/raw-salmon-meat_74190-1592.jpg?w=1380&t=st=1668534014~exp=1668534614~hmac=e1cb4b7b026444b95a5c0c5f9ec2f456568e1d925029a11b6792b9481562f92f",
                    Type = Fish,
                    Description = "Salmon is the common name for several commercially important species of euryhaline ray-finned fish from the family Salmonidae, which are native to tributaries of the North Atlantic (genus Salmo) and North Pacific basin. Other closely related fish in the same family include trout, char, grayling, whitefish, lenok and taimen.",
                    Origin = "Ocean"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Egg",
                    ImageUrl = "https://i.guim.co.uk/img/media/db9a96e1251a41a215ada849407983cedadc2fbb/0_252_2574_1545/master/2574.jpg?width=620&quality=85&dpr=1&s=none",
                    Type = Egg,
                    Description = "An egg is an organic vessel grown by an animal to carry a possibly fertilized egg cell (a zygote) and to incubate from it an embryo within the egg until the embryo has become an animal fetus that can survive on its own, at which point the animal hatches.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Milk",
                    ImageUrl = "https://solidstarts.com/wp-content/uploads/Milk-for-Babies-480x320.webp",
                    Type = Milk,
                    Description = "Milk is a white liquid food produced by the mammary glands of mammals. It is the primary source of nutrition for young mammals (including breastfed human infants) before they are able to digest solid food Immune factors and immune-modulating components in milk contribute to milk immunity.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Parmesan",
                    ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272",
                    Type = Cheese,
                    Description = "Parmesan (Italian: Parmigiano Reggiano; Italian pronunciation: [parmiˈdʒaːno redˈdʒaːno]) is an Italian hard, granular cheese produced from cows’ milk and aged at least 12 months.",
                    Origin = "Italy"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cream fresh",
                    ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272",
                    Type = Cream,
                    Description = "Cream fresh is a dairy product, a soured cream containing 10–45% butterfat, with a pH of approximately 4.5. It is soured with a bacterial culture.",
                    Origin = "France"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cream fresh",
                    ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/parmesan-00f8b31.jpg?quality=90&webp=true&resize=300,272",
                    Type = Cream,
                    Description = "Cream fresh is a dairy product, a soured cream containing 10–45% butterfat, with a pH of approximately 4.5. It is soured with a bacterial culture.",
                    Origin = "France"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Merguez",
                    ImageUrl = "https://thegourmetgoatfarmer.co.uk/wp-content/uploads/2021/01/Merguez-Sausages-600x461.jpg",
                    Type = Sausage,
                    Description = "Merguez s a red, spicy mutton- or beef-based fresh sausage in Maghrebi cuisine.[1][2] Since the late 20th century, it has been popular in France and Great Britain due to the large Algerian populations",
                    Origin = "Africa"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Linguine",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/da/Linguine.jpg",
                    Type = Pasta,
                    Description = "Linguine sometimes anglicized as linguini is a type of pasta similar to fettuccine and trenette but elliptical in section rather than flat.",
                    Origin = "Italy"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Squid Ink",
                    ImageUrl = "https://chgojohn.files.wordpress.com/2015/12/squid-ink.jpg",
                    Type = Food_coloring,
                    Description = "Squid Ink is a dark-coloured or luminous ink released into water by most species of cephalopod, usually as an escape mechanism. Modern use of cephalopod ink is generally limited to cooking, primarily in Japan and the Mediterranean, where it is used as a food colouring and flavouring, for example in pasta and sauces, and calamares en su tinta.",
                    Origin = "Ocean"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Butter",
                    ImageUrl = "https://media.npr.org/assets/img/2017/02/23/butter1_custom-340e5902a868b66b8f11aca60a5b2eed334971eb-s800-c85.webp",
                    Type = Fat,
                    Description = "Squid Ink is a dark-coloured or luminous ink released into water by most species of cephalopod, usually as an escape mechanism. Modern use of cephalopod ink is generally limited to cooking, primarily in Japan and the Mediterranean, where it is used as a food colouring and flavouring, for example in pasta and sauces, and calamares en su tinta.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pistacio",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Pistachio_macro_whitebackground_NS.jpg/220px-Pistachio_macro_whitebackground_NS.jpg",
                    Type = Nut,
                    Description = "The pistachio a member of the cashew family, is a small tree originating from Central Asia and the Middle East. The tree produces seeds that are widely consumed as food.",
                    Origin = "Middle East"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Multigrain Loaf",
                    ImageUrl = "https://www.seasonsandsuppers.ca/wp-content/uploads/2021/09/multigrain-bread-1200-600x600.jpg",
                    Type = Bread,
                    Description = "Multigrain bread is made with different types of flour and Theobroma’s multigrain loaf offers you the goodness of 8 different types of flour. This includes jowar, ragi, soya, oats and whole wheat flour.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cognac",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Cognac_glass_-_tulip_shaped.JPG/800px-Cognac_glass_-_tulip_shaped.JPG",
                    Type = Alcohol,
                    Description = "Cognac is a variety of brandy named after the commune of Cognac, France. It is produced in the surrounding wine-growing region in the departments of Charente and Charente-Maritime.Cognac production falls under French appellation d'origine contrôlée designation, with production methods and naming required to meet certain legal requirements. Among the specified grapes, Ugni blanc, known locally as Saint-Émilion, is most widely used.",
                    Origin = "France"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Peas",
                    ImageUrl = "https://www.almanac.com/sites/default/files/styles/max_1300x1300/public/image_nodes/peas-and-pea-pods.jpg?itok=qWmqcepy",
                    Type = Pulses,
                    Description = "Peas are annual plants, with a life cycle of one year. They are a cool-season crop grown in many parts of the world, planting can take place from winter to early summer depending on location. The average pea weighs between 0.1 and 0.36 gram.The immature peas (and in snow peas the tender pod as well) are used as a vegetable, fresh, frozen or canned, varieties of the species typically called field peas are grown to produce dry peas like the split pea shelled from a matured pod.",
                    Origin = "Mediterranean region"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Arborio rice",
                    ImageUrl = "https://cdn.apartmenttherapy.info/image/upload/f_auto,q_auto:eco,c_fill,g_center,w_730,h_487/k%2FPhoto%2FSeries%2F2021-03-rice-o-pedia%2FArborio-Rice%2F2021-03-30_ATK-48176-Rice-Arborio",
                    Type = Rice,
                    Description = "rborio rice is an Italian short-grain rice. It is named after the town of Arborio, in the Po Valley, which is situated in the region of Piedmont in Italy. When cooked, the rounded grains are firm, and creamy and chewy compared to other varieties of rice, due to their higher amylopectin starch content It has a starchy taste and blends well with other flavours.",
                    Origin = "Italy"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Honey",
                    ImageUrl = "https://5.imimg.com/data5/YH/RH/MY-43324479/natural-honey-1000x1000.jpg",
                    Type = Honey,
                    Description = "Honey is a sweet and viscous substance made by several bees, the best-known of which are honey bees.Honey is made and stored to nourish bee colonies. Bees produce honey by gathering and then refining the sugary secretions of plants (primarily floral nectar) or the secretions of other insects, like the honeydew of aphids.",
                    Origin = "All over the world"
                },
                new Ingredient()
                {
                    Id = Guid.NewGuid(),
                    Name = "Water",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Water_drop_001.jpg/1920px-Water_drop_001.jpg",
                    Type = Liquid,
                    Description = "Water is an inorganic, transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's hydrosphere and the fluids of all known living organisms. It is vital for all known forms of life, despite providing neither food, energy, nor organic micronutrients",
                    Origin = "All over the world"
                },
            };

            return ingredients;
        }
    }
}
