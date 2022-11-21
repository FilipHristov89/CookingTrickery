using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Infrastructure.Data;
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

        public async Task<IEnumerable<IngredientByTypeViewModel>> GetIngredientsByTypeAsync(int ingredientType)
        {
            IngredientTypeEnum neededType = (IngredientTypeEnum)ingredientType;
            
            var ingredients = await repo.AllReadonly<Ingredient>()
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

        public async Task<IEnumerable<IngredientTypeViewModel>> GetTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
