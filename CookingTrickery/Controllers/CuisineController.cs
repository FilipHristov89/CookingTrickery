using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Cuisines;
using CookingTrickery.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    [Authorize]
    public class CuisineController : Controller
    {
        private ICuisineService cuisineService;
        private IRecipeService recipeService;

        public CuisineController(ICuisineService _cuisineService, IRecipeService _recipeService)
        {
            cuisineService = _cuisineService;
            recipeService = _recipeService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Cuisines()
        {
            var model = await cuisineService.GetAllCuisinesAsync();

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Cuisine(Guid id)
        {
            var model = await cuisineService.GetCuisineAsync(id);

            model.CuisineRecipe = await recipeService.GetLastThreeCuisineRecipes(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateCuisineViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCuisineViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await cuisineService.CreateCuisine(model);
                return View(nameof(Cuisines));
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Wrong values, please try again");
                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddFavoriteCuisine(Guid id)
        {
            await cuisineService.AddFavoriteCuisineAsync(User.Id(), id);
            return RedirectToAction(nameof(Cuisines));
        }
    }
}
