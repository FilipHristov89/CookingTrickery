using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly CookingTrickeryDbContext context;

        public IngredientService(CookingTrickeryDbContext _context)
        {
            context = _context;
        }

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

            await context.Ingredients.AddAsync(ingredient);
            await context.SaveChangesAsync();
        }

        public async Task<IngredientViewModel> GetIngredientAsync(Guid id)
        {
            var ingredient = await context
                .Ingredients
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
                .FirstOrDefaultAsync();

            return ingredient;
        }

        public async Task<IEnumerable<IngredientByTypeViewModel>> GetIngredientsByTypeAsync(int ingredientType)
        {
            IngredientTypeEnum neededType = (IngredientTypeEnum)((int)ingredientType);
            
            var ingredients = await context
                .Ingredients
                .Where(i => i.Type == neededType)
                .Select(i => new IngredientByTypeViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    ImageUrl = i.ImageUrl,
                    Type = i.Type.ToString()
                })
                .ToListAsync();

            return ingredients;
        }
    }
}
