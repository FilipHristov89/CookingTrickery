using CookingTrickery.Core.Contracts.Administration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CookingTrickery.Infrastructure.Data.Entities;
using static CookingTrickery.Core.Constants.MessageConstant;
using static CookingTrickery.Areas.Administration.Common.AdminConstants.AdminMessagesConstants;
using static CookingTrickery.Common.Constants.ControllerAndMethodConstants.ControllerConstants;
using static CookingTrickery.Common.Constants.ControllerAndMethodConstants.RecipeControllerMethodConstants;


namespace CookingTrickery.Areas.Administration.Controllers
{
    public class UserController : BaseController
    {
        
        private readonly IUserService userService;
        private readonly SignInManager<User> signInManager;
        public UserController(IUserService _userService, SignInManager<User> _signInManager)
        {
            userService = _userService;
            signInManager = _signInManager;
        }
        public async Task<IActionResult> All()
        {
            var model = await userService.All();
                
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Forget(string userId)
        {
            bool result = await userService.Forget(userId);

            if (result)
            {
                TempData[SuccessMessage] = UserIsForgoten;
            }
            else
            {
                TempData[ErrorMessage] = UserCannotBeForgoten;
            }

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction(RecipeAllMethod, RecipeControllerValue, new { area = "" });
        }
    }
}
