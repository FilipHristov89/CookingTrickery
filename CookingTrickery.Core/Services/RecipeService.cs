using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository repo;

        public RecipeService(IRepository _repo)
        {
            repo = _repo;
        }

        public Task<CreateRecipeViewModel> CreateRecipeAsync(RecipePreviewViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecipePreviewViewModel>> GetAllRecipeAsync()
        {
            var entities = await repo.AllReadonly<Recipe>()
                .Include(r => r.Cuisine)
                .Include(r => r.User)
                .ToListAsync();

            return entities
                .Select(r => new RecipePreviewViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    QuickDescription = r.QuickDescription,
                    ImageUrl = r.ImageUrl,
                    Cuisine = r?.Cuisine?.Name,
                    User = r.User.UserName
                });
        }

        public async Task<IEnumerable<Cuisine>> GetCuisinesAsync()
        {
            return await repo.AllReadonly<Cuisine>().ToListAsync();
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsAsync()
        {
            return await repo.AllReadonly<Ingredient>().ToListAsync();
        }

        public async Task<RecipeViewModel> GetRecipeAsync(Guid id)
        {
            var entity = await repo.AllReadonly<Recipe>()
                .Where(r => r.Id == id)
                .Include(r => r.Cuisine)
                .Include(r => r.User)
                .Select(r => new RecipeViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    QuickDescription = r.QuickDescription,
                    ImageUrl = r.ImageUrl,
                    Cuisine = r.Cuisine.Name,
                    Ingredients = r.Ingredients
                        .Select(i => new RecipeIngredientModel()
                        {
                            Ingredient = i.Ingredient.Name,
                            Quantity = i.Measurement.Quantity,
                            Measurement = i.Measurement.MeasurementType.ToString()
                        })
                        .OrderBy(i => i.Ingredient)
                        .ToList(),
                    NumberOfServings = r.NumberOfServing,
                    PrepTime = r.PrepTime,
                    Description = r.Description,
                    User = r.User.UserName
                })
                .FirstAsync();

            return entity;
        }

        public async Task<IEnumerable<UserRecipesViewModel>> GetUserRecipes(string userId)
        {
            var recipes = await repo.AllReadonly<Recipe>()
                .Where(r => r.UserId == userId)
                .Select(r => new UserRecipesViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    ImageUrl = r.ImageUrl,
                    QuickDescription = r.QuickDescription,
                    CuisineId = r.CuisineId,
                    Cuisine = r.Cuisine.Name
                })
                .ToListAsync();

            return recipes;
        }
    }
}
