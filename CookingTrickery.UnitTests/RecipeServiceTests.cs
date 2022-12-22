using CookingTrickery.Core.Contracts;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp;
using CookingTrickery.Infrastructure.Data.Entities;
using CookingTrickery.Core.Services;
using CookingTrickery.Core.Exceptions;
using CookingTrickery.Core.Models.Recipe;

namespace CookingTrickery.UnitTests
{
    public class RecipeServiceTests
    {
        IGuard guard;
        private IRepository repo;
        private IRecipeService recipeService;
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
        public async Task TestCreateRecipe()
        {
            var repo = new Repository(context);
            recipeService = new RecipeService(repo, guard);

            var recipe = new CreateRecipeViewModel()
            {
                Name = "Chicken Wings",
                QuickDescription = "Chicken Wings Chicken Wings Chicken Wings",
                Description = "Chiiiiiicken wings",
                ImageUrl = " ",
                CuisineId = Guid.Parse("6fceadd3-28c8-4953-a3ea-2acaaea9746e"),
                PrepTime = " ",
                NumberOfServings = 1,
                IngredientMeasurement = "[{\"quantity\":2,\"measurement\":\"1\",\"ingredientId\":\"3ea505ff-7e9a-4540-8100-182123ce9605\"}]"
            };

            string userID = "07e41de4-fb4c-4044-9a76-d3077cdb0869";

            await recipeService.CreateRecipeAsync(recipe, userID);

            var dbRecipe = repo.AllReadonly<Recipe>();

            Assert.That(1, Is.EqualTo(dbRecipe.Count()));
        }

        [Test]
        public async Task TestGetRecipeAsync() 
        {
            var repo = new Repository(context);
            recipeService = new RecipeService(repo, guard);

            await repo.AddAsync(new Recipe
            {
                Id = Guid.Parse("14d5f813-117d-4ef9-80b6-9d5aaefe3dd4"),
                Name = "Chicken Wings",
                QuickDescription = "Chicken Wings Chicken Wings Chicken Wings",
                Description = "Chiiiiiicken wings",
                ImageUrl = "",
                CreatedOn = DateTime.Now,
                UserId = "",
                CuisineId = Guid.Parse("6fceadd3-28c8-4953-a3ea-2acaaea9746e"),
                NumberOfServing = 2,
                PrepTime = "",
                Ingredients = new List<IngredientMeasurement>()
            });

            await repo.SaveChangesAsync();


            var dbRecipe = await recipeService
                .GetRecipeAsync(Guid.Parse("14d5f813-117d-4ef9-80b6-9d5aaefe3dd4"));


            Assert.That(dbRecipe.Name, Is.EqualTo("Chicken Wings"));
        }

        private async Task PopulateDatabaseWithRecipes(Repository repo)
        {
            await repo.AddRangeAsync<Recipe>(new List<Recipe>
            {
                new Recipe()
                {
                    Id = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                    Name = "Slow Cooked Beef Stew",
                    QuickDescription = "Everyone’s favorite cozy beef stew made in the crockpot! The meat is SO TENDER and the stew is rich",
                    Description = "Heat olive oil in a large cast iron skillet over medium heat.Season beef with salt and pepper, to taste. Add beef to the skillet and cook until evenly browned, about 2-3 minutes.Place beef, potatoes, carrots, onion and garlic into a 6-qt slow cooker. Stir in beef broth, tomato paste, Worcestershire, thyme, rosemary, paprika, caraway seeds and bay leaves until well combined; season with salt and pepper, to taste.Cover and cook on low heat for 7-8 hours or high heat for 3-4 hours.In a small bowl, whisk together flour and 1/2 cup stew broth. Stir in flour mixture into the slow cooker. Cover and cook on high heat for an additional 30 minutes, or until thickened.Serve immediately, garnished with parsley, if desired.",
                    PrepTime = "8 hours",
                    CuisineId = Guid.Parse("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"),
                    NumberOfServing = 4,
                    CreatedOn = DateTime.Now.ToLocalTime(),
                    UserId = "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                    ImageUrl = "https://s23209.pcdn.co/wp-content/uploads/2016/10/221024_DD_Slow-Cooker-Beef-Stew_218-760x1140.jpg",
                    Ingredients = new List<IngredientMeasurement>()
                },
                new Recipe
                {
                    Id = Guid.Parse("14d5f813-117d-4ef9-80b6-9d5aaefe3dd4"),
                    Name = "Chicken Wings",
                    QuickDescription = "Chicken Wings Chicken Wings Chicken Wings",
                    Description = "Chiiiiiicken wings",
                    ImageUrl = "",
                    CreatedOn = DateTime.Now,
                    UserId = "",
                    CuisineId = Guid.Parse("6fceadd3-28c8-4953-a3ea-2acaaea9746e"),
                    NumberOfServing = 2,
                    PrepTime = ""
                }
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
