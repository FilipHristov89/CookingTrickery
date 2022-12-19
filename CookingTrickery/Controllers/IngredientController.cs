using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Models.Recipe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    [Authorize]
    public class IngredientController : Controller
    {
        private IIngredientService ingredientService;

        public IngredientController(IIngredientService _service)
        {
            ingredientService = _service;
        }
        [AllowAnonymous]
        public IActionResult All()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Ingredient(Guid id)
        {
            var model = await ingredientService.GetIngredientAsync(id);

            model.IngredientRecipe = await ingredientService.GetLastThreeRecipesWithIngredient(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateIngredient()
        {
            var model = new CreateIngredientViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIngredient(CreateIngredientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await ingredientService.CreateIngredientAsync(model);
                return View(nameof(AllIngredients));
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Wrong values, please try again");
                return View(model);
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllIngredients([FromQuery]AllIngredientsQueryModel queryModel)
        {
            var ingredients = await ingredientService.AllIngredientsAsync(
                queryModel.IngredientName,
                queryModel.IngredientOrigin,
                queryModel.IngredientType,
                queryModel.Sorting
                );
            queryModel.TotalIngredientsCount = ingredients.TotalIngredientsCount;
            queryModel.Ingredients = ingredients.Ingredients;

            return View(queryModel);
        }
    }
}
