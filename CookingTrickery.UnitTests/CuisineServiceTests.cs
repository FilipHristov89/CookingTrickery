using CookingTrickery.Core.Contracts;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookingTrickery.Core.Services;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.CodeAnalysis.CSharp;
using CookingTrickery.Core.Exceptions;
using System.Security.Policy;
using CookingTrickery.Core.Models.Cuisines;

namespace CookingTrickery.UnitTests
{
    public class CuisineServiceTests
    {
        IGuard guard;
        private IRepository repo;
        private ICuisineService cuisineService;
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
        public async Task TestCreateCuisine()
        {
            var repo = new Repository(context);

            cuisineService = new CuisineService(repo, guard);

            var cuisine =  new CreateCuisineViewModel()
            {
                Name = "African Cuisine",
                ImageUrl = "",
                Description = "Some african food"
            };

            await cuisineService.CreateCuisine(cuisine);

            var dbCuisines = repo.AllReadonly<Cuisine>();

            Assert.That(1, Is.EqualTo(dbCuisines.Count()));
        }

        [Test]
        public async Task TestGetCuisineById()
        {
            var repo = new Repository(context);
            cuisineService = new CuisineService(repo, guard);

            await PopulateDatabaseWithCuisines(repo);

            var dbCuisine = await cuisineService.GetCuisineAsync(Guid.Parse("b0de4591-35bc-4500-b84f-ee04c64775ea"));

            Assert.That(dbCuisine.Name, Is.EqualTo("Mexican Cuisine"));
        }

        [Test]
        public async Task TestGetAllCuisines()
        {
            var repo = new Repository(context);
            cuisineService = new CuisineService(repo, guard);

            await PopulateDatabaseWithCuisines(repo);


            var dbCuisines = await cuisineService.GetAllCuisinesAsync();

            Assert.That(3, Is.EqualTo(dbCuisines.Count()));
        }

        [Test]
        public async Task TestAddFavoriteCuisineAsyncWithExistingCuisine()
        {
            var repo = new Repository(context);
            cuisineService = new CuisineService(repo, guard);

            await PopulateDatabaseWithCuisines(repo);

            await PopulateDatabaseWithUser(repo);

            await cuisineService
                .AddFavoriteCuisineAsync(
                "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                Guid.Parse("a6521833-8514-4d09-b7c0-9ee03373ffc5") 
                );

            var dbCuisine = await repo
                .GetByIdAsync<Cuisine>(Guid.Parse("a6521833-8514-4d09-b7c0-9ee03373ffc5"));

            var dbUser = await repo
                .GetByIdAsync<User>("bc60d5f7-3884-42c6-9fb5-e1db55094536");

            Assert.That(dbUser.FavoriteCuisineId, Is.EqualTo(dbCuisine.Id));
        }


        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

        private async Task PopulateDatabaseWithCuisines(Repository repo)
        {
            await repo.AddRangeAsync(new List<Cuisine>
            {
                new Cuisine()
                {
                    Id = new Guid("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"),
                    Name = "British Cuisine",
                    ImageUrl = "https://fullsuitcase.com/wp-content/uploads/2021/01/Traditional-British-food.jpg",
                    Description = "British cuisine is the specific set of cooking traditions and practices associated with the United Kingdom. Historically, British cuisine meant \"unfussy dishes made with quality local ingredients, matched with simple sauces to accentuate flavour, rather than disguise it\". International recognition of British cuisine was historically limited to the full breakfast and the Christmas dinner. However, Celtic agriculture and animal breeding produced a wide variety of foodstuffs for indigenous Celts. Anglo-Saxon England developed meat and savoury herb stewing techniques before the practice became common in Europe. The Norman conquest introduced exotic spices into Great Britain in the Middle Ages"
                },
                new Cuisine()
                {
                    Id = new Guid("b0de4591-35bc-4500-b84f-ee04c64775ea"),
                    Name = "Mexican Cuisine",
                    ImageUrl = "https://images.squarespace-cdn.com/content/v1/53b839afe4b07ea978436183/1619636932396-6DZZR1WGINWYADFUCU9I/popular-food-in-mexico.jpg?format=1000w",
                    Description = "Mexican cuisine consists of the cooking cuisines and traditions of the modern country of Mexico. Its earliest roots lie in Mesoamerican cuisine. Its ingredients and methods begin with the first agricultural communities such as the Maya who domesticated maize, created the standard process of maize nixtamalization, and established their foodways (Maya cuisine). Successive waves of other Mesoamerican groups brought with them their own cooking methods. These included: the Olmec, Teotihuacanos, Toltec, Huastec, Zapotec, Mixtec, Otomi, Purépecha, Totonac, Mazatec, Mazahua, and Nahua. With the Mexica formation of the multi-ethnic Triple Alliance (Aztec Empire), culinary foodways became infused (Aztec cuisine)."
                },
                new Cuisine()
                {
                    Id = new Guid("a6521833-8514-4d09-b7c0-9ee03373ffc5"),
                    Name = "Bulgarian Cuisine",
                    ImageUrl = "https://i-winereview.com/blog/wp-content/uploads/2018/05/Header-BulgariaFood-1.jpg",
                    Description = "Bulgarian cuisine is a representative of the cuisine of Southeast Europe. It shares characteristics with other Balkan cuisines. Bulgarian cooking traditions are diverse because of geographical factors such as climatic conditions suitable for a variety of vegetables, herbs, and fruit. Aside from the vast variety of local Bulgarian dishes, Bulgarian cuisine shares a number of dishes with Persian, Turkish, and Greek cuisine.Bulgarian food often incorporates salads as appetizers and is also noted for the prominence of dairy products, wines and other alcoholic drinks such as rakia."
                }
            });
            await repo.SaveChangesAsync();
        }

        private async Task PopulateDatabaseWithUser(Repository repo)
        {
            var guestUser = new User()
            {
                Id = "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                UserName = "Guest",
                Email = "guest@gmail.com",
                FirstName = "Petar",
                LastName = "Petrov",
                NormalizedUserName = "GUEST",
                NormalizedEmail = "GUEST@GMAIL.COM"
            };

            await repo.AddAsync(guestUser);
            await repo.SaveChangesAsync();
        }
    }
}
