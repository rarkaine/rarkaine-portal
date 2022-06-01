using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Controllers;

namespace Rarkaine.Portal.Web.Public.Controllers
{
    public class AboutController : PortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}