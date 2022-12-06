using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Cuisines;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookingTrickery.Controllers
{
    [Authorize]
    public class CuisineController : Controller
    {
        private ICuisineService cuisineService;

        public CuisineController(ICuisineService _cuisineService)
        {
            cuisineService = _cuisineService;
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

            model.CuisineRecipe = await cuisineService.GetLastThreeCuisineRecipes(id);

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
    }
}
