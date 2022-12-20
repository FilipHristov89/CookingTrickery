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

        [HttpPost]
        public async Task<IActionResult> CreateRecipe(
            CreateRecipeViewModel model
            )
        {
            var userId = User.Id();

            var ingr = model.IngredientMeasurement;

            await recipeService.CreateRecipeAsync(model, userId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> MyCookbook()
        {
            var userId = User.Id();

            var recipes = await recipeService.GetUserRecipes(userId);

            return View(recipes);
        }

        public async Task<IActionResult> AddToFavoriteRecipes(Guid id)
        {
            await recipeService.AddToFavoriteRecipesAsync(id, User.Id());

            return RedirectToAction(nameof(MyFavorites));
        }

        [HttpGet]
        public async Task<IActionResult> MyFavorites()
        {
            var model = await recipeService.GetUserFavoriteRecipesAsync(User.Id());

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRecipe(Guid id)
        {
            await recipeService.DeleteRecipeAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
