using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Contracts
{
    public interface IRecipeService 
    {
        Task<IEnumerable<RecipePreviewViewModel>> GetAllRecipeAsync();

        Task<RecipeViewModel> GetRecipeAsync(Guid id);

        Task<CreateRecipeViewModel> CreateRecipeAsync(RecipePreviewViewModel recipe);

        Task<IEnumerable<Ingredient>> GetIngredientsAsync();
    }
}
