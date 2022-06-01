using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Session;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Themes.Theme9.Components.AdminTheme9Footer
{
    public class AdminTheme9FooterViewComponent : PortalViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme9FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
