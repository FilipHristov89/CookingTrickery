using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private IRecipeService recipeService;

        public RecipeController(IRecipeService _recipeService)
        {
            recipeService = _recipeService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await recipeService.GetAllRecipeAsync();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Recipe(Guid id)
        {
            var model = await recipeService.GetRecipeAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateRecipe()
        {
            var model = new CreateRecipeViewModel()
            {
                Ingredients = await recipeService.GetIngredientsAsync(),
                Cuisines = await recipeService.GetCuisinesAsync()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyCookbook()
        {
            var userId = User.Id();

            var recipes = await recipeService.GetUserRecipes(userId);

            return View(recipes);
        }
    }
}
