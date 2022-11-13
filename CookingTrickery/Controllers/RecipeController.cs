using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeService recipeService;

        public RecipeController(IRecipeService _recipeService)
        {
            recipeService = _recipeService;
        }

        public async Task<IActionResult> All()
        {
            var model = await recipeService.GetAllRecipeAsync();

            return View(model);
        }

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
                Ingredients = await recipeService.GetIngredientsAsync()
            };

            return View(model);
        }
    }
}
