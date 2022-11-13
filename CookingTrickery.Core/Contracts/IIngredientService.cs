using CookingTrickery.Core.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Contracts
{
    public interface IIngredientService
    {
        Task<IngredientViewModel> GetIngredientAsync(Guid id);

        Task<IEnumerable<IngredientByTypeViewModel>> GetIngredientsByTypeAsync(int ingredientType);

        Task CreateIngredientAsync(CreateIngredientViewModel model);
    }
}
