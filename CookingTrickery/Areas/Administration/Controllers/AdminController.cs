using CookingTrickery.Controllers;
using CookingTrickery.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Areas.Administration.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IRecipeService recipeService;

        public AdminController(IRecipeService _recipeService)
        {
            recipeService = _recipeService;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
    