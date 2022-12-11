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

        public async Task<IActionResult> Index()
        {
            var model = await recipeService.GetLastThreeRecipeAsync();

            return View(model);
        }
    }
}
