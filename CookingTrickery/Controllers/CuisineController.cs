using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Cuisine;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CookingTrickery.Controllers
{
    public class CuisineController : Controller
    {
        private ICuisineService cuisineService;

        public CuisineController(ICuisineService _cuisineService)
        {
            cuisineService = _cuisineService;
        }

        public async Task<IActionResult> Cuisines()
        {
            var model = await cuisineService.GetAllCuisinesAsync();

            return View(model);
        }

        public async Task<IActionResult> Cuisine(Guid id)
        {
            var model = await cuisineService.GetCuisineAsync(id);

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
