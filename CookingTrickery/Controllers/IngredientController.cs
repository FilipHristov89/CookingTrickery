using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Ingredients;
using CookingTrickery.Core.Models.Recipe;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    public class IngredientController : Controller
    {
        private IIngredientService ingredientService;

        public IngredientController(IIngredientService _service)
        {
            ingredientService = _service;
        }

        public IActionResult All()
        {
            return View();
        }

        public async Task<IActionResult> Ingredient(Guid id)
        {
            var model = await ingredientService.GetIngredientAsync(id);

            return View(model);
        }

        public async Task<IActionResult> IngredientsByType(int ingredientType)
        {
            var model = await ingredientService.GetIngredientsByTypeAsync(ingredientType);

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
                return View(nameof(All));
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Wrong values, please try again");
                return View(model);
            }

        }
    }
}
