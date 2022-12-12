using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;

namespace CookingTrickery.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository repo;

        public RecipeService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task CreateRecipeAsync(CreateRecipeViewModel model, string userId, string[] recipeIngredients)
        {
            var recipe = new Recipe()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                QuickDescription = model.QuickDescription,
                ImageUrl = model.ImageUrl,
                //Ingredients = RecipeIngredients(recipeIngredients),
                CuisineId = model.CuisineId,
                NumberOfServing = model.NumberOfServings,
                PrepTime = model.PrepTime,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                UserId = userId
            };

            //await repo.AddAsync<Recipe>(recipe);
            //await repo.SaveChangesAsync();
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

        public async Task<IEnumerable<RecipePreviewViewModel>> GetLastThreeRecipeAsync()
        {
            var entity = await repo.AllReadonly<Recipe>()
                .OrderByDescending(r => r.CreatedOn)
                .Select(r => new RecipePreviewViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    ImageUrl = r.ImageUrl,
                    QuickDescription = r.QuickDescription,
                    Cuisine = r.Cuisine.Name,
                    User = r.User.UserName
                })
                .Take(3)
                .ToListAsync();

            return entity;
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

        private ICollection<IngredientMeasurement> RecipeIngredients(string[] ingredientList)
        {
            ICollection<IngredientMeasurement> ingredients = new List<IngredientMeasurement>();

            //foreach (var item in ingredientList)
            //{
            //    ingredientList.Add(new IngredientMeasurement()
            //    {
            //        Id = Guid.NewGuid(),
            //        IngredientId = item.ingredient
            //    })
            //}

            return ingredients;
        }
    }
}
