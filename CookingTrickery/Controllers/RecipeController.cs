using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Recipe()
        {
            return View();
        }
    }
}
