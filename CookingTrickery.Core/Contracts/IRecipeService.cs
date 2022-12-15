using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Contracts
{
    public interface IRecipeService 
    {
        Task<IEnumerable<RecipePreviewViewModel>> GetAllRecipeAsync();

        Task<RecipeViewModel> GetRecipeAsync(Guid id);

        Task CreateRecipeAsync(CreateRecipeViewModel recipe, string userId, string[] recipeIngredients);

        Task<IEnumerable<Ingredient>> GetIngredientsAsync();

        Task<IEnumerable<Cuisine>> GetCuisinesAsync();

        Task<IEnumerable<UserRecipesViewModel>> GetUserRecipes(string userId);

        Task<IEnumerable<RecipePreviewViewModel>> GetLastThreeRecipeAsync();

        Task<IEnumerable<RecipePreviewViewModel>> GetUserFavoriteRecipesAsync(string userId);

        Task AddToFavoriteRecipesAsync(Guid recipeId, string userId);

    }
}
