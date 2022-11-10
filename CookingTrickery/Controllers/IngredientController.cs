using CookingTrickery.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    public class IngredientController : Controller
    {
        private IIngredientService service;

        public IngredientController(IIngredientService _service)
        {
            service = _service;
        }

        public IActionResult All()
        {
            return View();
        }

        public async Task<IActionResult> Ingredient(Guid id)
        {
            var model = await service.GetIngredientAsync(id);

            return View(model);
        }

        public async Task<IActionResult> IngredientByType(string ingredientType)
        {
            var model = await service.GetIngredientsByTypeAsync(ingredientType);

            return View(model);
        }
    }
}
