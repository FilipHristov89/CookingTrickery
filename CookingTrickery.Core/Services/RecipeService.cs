using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Exceptions;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace CookingTrickery.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository repo;
        private readonly IGuard guard;

        public RecipeService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
        }

        public async Task AddToFavoriteRecipesAsync(Guid recipeId, string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            guard.AgainstNull(user, "User cannot be null");
            if (user == null)
            {
                throw new ArgumentException("Invalid user");
            }
            var recipe = await repo.GetByIdAsync<Recipe>(recipeId);

            if (recipe == null)
            {
                throw new ArgumentException("Invalid cuisine");
            }

            if (!user.FavoriteRecipes.Any(r => r.RecipeId == recipeId))
            {
                user.FavoriteRecipes.Add(new UsersFavorites()
                {
                    UserId = user.Id,
                    User = user,
                    RecipeId = recipe.Id,
                    Recipe = recipe
                });

                await repo.SaveChangesAsync();
            }
        }

        public async Task CreateRecipeAsync(CreateRecipeViewModel model, string userId)
        {

            var recipe = new Recipe()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                QuickDescription = model.QuickDescription,
                ImageUrl = model.ImageUrl,
                Ingredients = RecipeIngredients(model.IngredientMeasurement),
                CuisineId = model.CuisineId,
                NumberOfServing = model.NumberOfServings,
                PrepTime = model.PrepTime,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                UserId = userId
            };

            await repo.AddAsync<Recipe>(recipe);
            await repo.SaveChangesAsync();
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

        public async Task<IEnumerable<RecipePreviewViewModel>> GetLastThreeRecipesWithIngredient(Guid id)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => r.Ingredients.Any(i => i.IngredientId == id))
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

        public async Task<IEnumerable<RecipePreviewViewModel>> GetUserFavoriteRecipesAsync(string userId)
        {
            var recipe = await repo.AllReadonly<UsersFavorites>()
                .Include(uf => uf.Recipe)
                .Where(uf => uf.UserId == userId)
                .Select(uf => new RecipePreviewViewModel()
                {
                    Id = uf.RecipeId,
                    Name = uf.Recipe.Name,
                    QuickDescription = uf.Recipe.QuickDescription,
                    ImageUrl = uf.Recipe.ImageUrl,
                    Cuisine = uf.Recipe.Cuisine.Name,
                    User = uf.User.UserName
                })
                .ToListAsync();

            return recipe;
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

        public async Task DeleteRecipeAsync(Guid recipeId)
        {
            var recipe = await repo.GetByIdAsync<Recipe>(recipeId);

            var recipeIngredients = await repo.All<IngredientMeasurement>()
                .Where(im => im.RecipeId == recipeId)
                .ToListAsync();

            guard.AgainstNull(recipeId, "Id cannot be null");

            await repo.DeleteAsync<Recipe>(recipeId);
            repo.DeleteRange<IngredientMeasurement>(recipeIngredients);
            await repo.SaveChangesAsync();
        }

        private ICollection<IngredientMeasurement> RecipeIngredients(string ingredientList)
        {

            guard.AgainstNull(ingredientList, "Ingredients cannot be null");

            IngredientsMeasurementModel[] model = JsonConvert.DeserializeObject<IngredientsMeasurementModel[]>(ingredientList);

            ICollection<IngredientMeasurement> ingredients = new List<IngredientMeasurement>();

            foreach (IngredientsMeasurementModel item in model)
            {
                if (!IsValid(item))
                {
                    throw new ArgumentException("Invalid Data");
                }

                IngredientMeasurement ingredient = new IngredientMeasurement()
                {
                    Id = Guid.NewGuid(),
                    IngredientId = item.IngredientId,
                    Measurement = new Measurement()
                    {
                        Id = Guid.NewGuid(),
                        Quantity = item.Quantity,
                        MeasurementType = (MeasurementTypeEnum)item.Measurement
                    },
                };

                ingredients.Add(ingredient);
            }

            return ingredients;
        }

        private static bool IsValid(object item)
        {
            var validationContext = new ValidationContext(item);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(item, validationContext, validationResult, true);
        }
    }
}
