using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository repo;

        public IngredientService(IRepository _repo)
        {
            repo = _repo;
        }


        /// <summary>
        /// Create new ingredient
        /// </summary>
        /// <param name="model">Create ingredinent view form</param>
        /// <returns>Add the ingredient to the database</returns>
        public async Task CreateIngredientAsync(CreateIngredientViewModel model)
        {
            var ingredient = new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Type = model.Type,
                Description = model.Description,
                Calories = model.Calories,
                Origin = model.Origin
            };

            await repo.AddAsync(ingredient);
            await repo.SaveChangesAsync();
        }
        /// <summary>
        /// Gets all ingredients by chosen fiter/s
        /// </summary>
        /// <param name="ingredientName">Filter for the name</param>
        /// <param name="ingredientOrigin">Filter for the origin</param>
        /// <param name="ingredientType">Filter for the type</param>
        /// <param name="sorting">Filter for the type of order</param>
        /// <returns>List of filtered ingredients</returns>
        public async Task<IngredientQueryModel> AllIngredientsAsync(string? ingredientName = null, string? ingredientOrigin = null, IngredientTypeEnum ingredientType = IngredientTypeEnum.None, IngredientSorting sorting = IngredientSorting.Alphabetically)
        {
            var result = new IngredientQueryModel();
            var ingredients = repo.AllReadonly<Ingredient>();

            if (string.IsNullOrEmpty(ingredientName) == false)
            {
                ingredientName = $"%{ingredientName.ToLower()}%";
                ingredients = ingredients
                    .Where(i => EF.Functions.Like(i.Name.ToLower(), ingredientName));
            }

            if (string.IsNullOrEmpty(ingredientOrigin) == false)
            {
                ingredientOrigin = $"%{ingredientOrigin.ToLower()}%";
                ingredients = ingredients
                    .Where(i => EF.Functions.Like(i.Origin.ToLower(),ingredientOrigin));
            }

            if (ingredientType != IngredientTypeEnum.None)
            {
                ingredients = ingredients
                    .Where(i => i.Type == ingredientType);
            }

            ingredients = sorting switch
            {
                IngredientSorting.AlphabeticallyDec => ingredients
                    .OrderByDescending(i => i.Name),
                IngredientSorting.ByCalories => ingredients
                    .OrderBy(i => i.Calories),
                IngredientSorting.ByCaloriesDec => ingredients
                    .OrderByDescending(i => i.Calories),
                _ => ingredients.OrderBy(i => i.Name)
            };

            result.Ingredients = await ingredients
                .Select(i => new IngredientPreviewViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    ImageUrl = i.ImageUrl,
                    Type = i.Type,
                    Origin = i.Origin,
                    Calories = i.Calories
                })
                .ToListAsync();

            result.TotalIngredientsCount = await ingredients.CountAsync();

            return result;
        }

        /// <summary>
        /// Get a ingredient by id
        /// </summary>
        /// <param name="id">Chosen ingredient</param>
        /// <returns>Selected Ingredient</returns>
        public async Task<IngredientViewModel> GetIngredientAsync(Guid id)
        {
            var ingredient = await repo.AllReadonly<Ingredient>()
                .Where(i => i.Id == id)
                .Select(i => new IngredientViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    ImageUrl = i.ImageUrl,
                    Type = i.Type.ToString(),
                    Calories = i.Calories,
                    Origin = i.Origin,
                    Description = i.Description
                })
            .FirstAsync();

            return ingredient;
        }
    }
}
