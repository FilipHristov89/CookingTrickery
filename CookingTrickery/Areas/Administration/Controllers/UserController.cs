using CookingTrickery.Core.Contracts.Administration;
using Microsoft.AspNetCore.Mvc;

using static CookingTrickery.Core.Constants.MessageConstant;
using static CookingTrickery.Areas.Administration.Common.AdminConstants.AdminMessagesConstants;


namespace CookingTrickery.Areas.Administration.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
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
    }
}
