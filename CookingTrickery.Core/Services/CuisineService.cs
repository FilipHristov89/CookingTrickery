using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Cuisines;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class CuisineService : ICuisineService
    {
        private readonly IRepository repo;

        public CuisineService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task CreateCuisine(CreateCuisineViewModel model)
        {
            var cuisine = new Cuisine()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description
            };

            await repo.AddAsync(cuisine);
            await repo.SaveChangesAsync();
        }

        public async Task AddFavoriteCuisineAsync(string userId, Guid cuisineId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            if (user == null)
            {
                throw new ArgumentException("Invalid user");
            }
            var cuisine = await repo.GetByIdAsync<Cuisine>(cuisineId);

            if (cuisine == null)
            {
                throw new ArgumentException("Invalid cuisine");
            }

            user.FavoriteCuisine = cuisine;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync()
        {
            var cuisines = await repo.AllReadonly<Cuisine>()
                .Select(c => new CuisinePreviewViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                })
                .ToListAsync();

            return cuisines;
        }

        public async Task<CuisineViewModel> GetCuisineAsync(Guid id)
        {
            var cuisine = await repo.AllReadonly<Cuisine>()
                .Where(c => c.Id == id)
                .Select(c => new CuisineViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description,
                })
                .FirstAsync();

            return cuisine;
        }

        public async Task<IEnumerable<RecipePreviewViewModel>> GetLastThreeCuisineRecipes(Guid id)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => r.CuisineId == id)
                .OrderByDescending(r => r.CreatedOn)
                .Select(r => new RecipePreviewViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    QuickDescription = r.QuickDescription,
                    ImageUrl = r.ImageUrl,
                    Cuisine = r.Cuisine.Name,
                    User = r.User.UserName,
                })
                .Take(3)
                .ToListAsync();
        }
    }
}
