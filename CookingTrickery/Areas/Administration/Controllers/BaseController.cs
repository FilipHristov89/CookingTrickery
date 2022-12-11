using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static CookingTrickery.Areas.Administration.Common.AdminConstants.AdminRolesConstants;
using static CookingTrickery.Areas.Administration.Common.AdminConstants.AdminAreasConstant;

namespace CookingTrickery.Areas.Administration.Controllers
{
    [Area(AdminArea)]
    [Authorize(Roles = Administrator)]
    public class BaseController : Controller
    {
    }
}
