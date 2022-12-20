using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Common;
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

        Task CreateIngredientAsync(CreateIngredientViewModel model);

        Task<IngredientQueryModel> AllIngredientsAsync(string? ingredientName = null, string? ingredientOrigin = null, IngredientTypeEnum ingredientType = IngredientTypeEnum.None, IngredientSorting sorting = IngredientSorting.Alphabetically);

    }
}
