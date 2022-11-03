using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Ingredient()
        {
            return View();
        }
    }
}
