using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Controllers;

namespace Rarkaine.Portal.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize]
    public class WelcomeController : PortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}