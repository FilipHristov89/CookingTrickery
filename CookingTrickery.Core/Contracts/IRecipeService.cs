using CookingTrickery.Core.Models;
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
    }
}
