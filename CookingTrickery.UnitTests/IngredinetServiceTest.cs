using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Exceptions;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Services;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;

using static CookingTrickery.Infrastructure.Data.Common.IngredientTypeEnum;

namespace CookingTrickery.UnitTests
{
    public class IngredientServiceTests
    {
        
        private IRepository repo;
        private IIngredientService ingredientService;
        private CookingTrickeryDbContext context;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<CookingTrickeryDbContext>()
                .UseInMemoryDatabase("IngredientDb")
                .Options;

            context = new CookingTrickeryDbContext(contextOptions);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        [Test]
        public async Task TestCreateIngredients()
        {
            var repo = new Repository(context);

            ingredientService = new IngredientService(repo);

            var ingredient = new CreateIngredientViewModel()
            {
                Name = "Pork",
                ImageUrl = "",
                Calories = 200,
                Type = Meat,
                Origin = "All over the world",
                Description = "Best Meat"
            };

            await ingredientService.CreateIngredientAsync(ingredient);

            var dbIngredients = repo.AllReadonly<Ingredient>();


            Assert.That(1, Is.EqualTo(dbIngredients.Count()));
        }
        [Test]
        public async Task TestGetIngredientAsync()
        {
            var repo = new Repository(context);
            ingredientService = new IngredientService(repo);

            await PopulateDatabaseWithIngredients(repo);

            var ingredient = await ingredientService
                .GetIngredientAsync(Guid.Parse("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"));

            Assert.That(ingredient.Id, Is.EqualTo(Guid.Parse("6e56c040-63ec-4fa8-9c87-ba3a1a732a22")));
            Assert.That(ingredient.Name, Is.EqualTo("Olive Oil"));
        }

        [Test]
        public async Task TestAllIngredientsWithoutFilters()
        {
            var repo = new Repository(context);
            ingredientService = new IngredientService(repo);

            await PopulateDatabaseWithIngredients(repo);

            string? ingredientName = null;
            string? ingredientOrigin = null;
            IngredientTypeEnum ingredientType = IngredientTypeEnum.None;
            IngredientSorting sorting = IngredientSorting.Alphabetically;

            var ingredients = await ingredientService.AllIngredientsAsync(
                ingredientName, 
                ingredientOrigin, 
                ingredientType, 
                sorting);

            Assert.That(3, Is.EqualTo(ingredients.TotalIngredientsCount));
        }

        [Test]
        public async Task TestAllIngredientsFilteredByName()
        {
            var repo = new Repository(context);
            ingredientService = new IngredientService(repo);

            await PopulateDatabaseWithIngredients(repo);

            string? ingredientName = "Oni";
            string? ingredientOrigin = null;
            IngredientTypeEnum ingredientType = IngredientTypeEnum.None;
            IngredientSorting sorting = IngredientSorting.Alphabetically;

            var ingredients = await ingredientService.AllIngredientsAsync(
                ingredientName,
                ingredientOrigin,
                ingredientType,
                sorting);

            Assert.That(1, Is.EqualTo(ingredients.TotalIngredientsCount));
        }

        [Test]
        public async Task TestAllIngredientsFilteredByOrigin()
        {
            var repo = new Repository(context);
            ingredientService = new IngredientService(repo);

            await PopulateDatabaseWithIngredients(repo);

            string? ingredientName = null;
            string? ingredientOrigin = "Asia";
            IngredientTypeEnum ingredientType = IngredientTypeEnum.None;
            IngredientSorting sorting = IngredientSorting.Alphabetically;

            var ingredients = await ingredientService.AllIngredientsAsync(
                ingredientName,
                ingredientOrigin,
                ingredientType,
                sorting);

            Assert.That(2, Is.EqualTo(ingredients.TotalIngredientsCount));
        }

        [Test]
        public async Task TestAllIngredientsFilteredByType()
        {
            var repo = new Repository(context);
            ingredientService = new IngredientService(repo);

            await PopulateDatabaseWithIngredients(repo);

            string? ingredientName = null;
            string? ingredientOrigin = null; ;
            IngredientTypeEnum ingredientType = IngredientTypeEnum.Vegitable;
            IngredientSorting sorting = IngredientSorting.Alphabetically;

            var ingredients = await ingredientService.AllIngredientsAsync(
                ingredientName,
                ingredientOrigin,
                ingredientType,
                sorting);

            Assert.That(2, Is.EqualTo(ingredients.TotalIngredientsCount));
        }


        private async Task PopulateDatabaseWithIngredients(Repository repo)
        {
            await repo.AddRangeAsync(new List<Ingredient>
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
            });

            await repo.SaveChangesAsync();
        }
        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }
    }
}