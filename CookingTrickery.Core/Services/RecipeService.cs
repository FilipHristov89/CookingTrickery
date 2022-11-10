using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CookingTrickery.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly CookingTrickeryDbContext context;

        public RecipeService(CookingTrickeryDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<RecipePreviewViewModel>> GetAllRecipeAsync()
        {
            var entities = await context
                .Recipes
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

        public async Task<RecipeViewModel> GetRecipeAsync(Guid id)
        {
            var entity = await context
                .Recipes
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

        //private async Task<ICollection<RecipeIngredientModel>> GetRecipeIngredientsAsync(Guid id)
        //{
        //    var ingredients = await context
        //        .Recipes
        //        .Where(r => r.Id == id)
        //        .Include(r => r.Ingredients)
        //        .ToListAsync()

        //        .Select(r => r.Ingredients)
                
        //}
    }
}
