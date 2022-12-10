using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Extensions;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Text.Json.Nodes;

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
            CreateRecipeViewModel model,
            string recipeIngredients)
        {
            var userId = User.Id();

            await recipeService.CreateRecipeAsync(model, userId, recipeIngredients);

            return RedirectToAction("Recipe/All");
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetRecipeIngredients([FromBody] string ingredients)
        {
            return Ok();
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
