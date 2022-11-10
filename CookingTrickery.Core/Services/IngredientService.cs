using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Services 
{
    public class IngredientService : IIngredientService
    {
        private readonly CookingTrickeryDbContext context;

        public IngredientService(CookingTrickeryDbContext _context)
        {
            context = _context;
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

        public async Task<IEnumerable<IngredientByTypeViewModel>> GetIngredientsByTypeAsync(string ingredientType)
        {
            var ingredients = await context
                .Ingredients
                .Where(i => i.Type.ToString() == ingredientType)
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
