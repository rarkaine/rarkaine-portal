using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Controllers;

namespace Rarkaine.Portal.Web.Public.Controllers
{
    public class HomeController : PortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}