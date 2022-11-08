using CookingTrickery.Core.Contracts;
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
    }
}
