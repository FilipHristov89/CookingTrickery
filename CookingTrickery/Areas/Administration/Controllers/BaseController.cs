using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static CookingTrickery.Common.Constants.UserRolesConstant;

namespace CookingTrickery.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = Administrator)]
    public class BaseController : Controller
    {
    }
}
