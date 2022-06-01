using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Session;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Themes.Theme6.Components.AdminTheme6Brand
{
    public class AdminTheme6BrandViewComponent : PortalViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme6BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string skin = "dark-sm")
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
            };

            ViewBag.BrandLogoSkin = skin;

            return View(headerModel);
        }
    }
}
