using System.Threading.Tasks;
using Abp.Configuration;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Configuration;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Session;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Components.AdminSubscriptionBar
{
    public class AdminSubscriptionBarViewComponent : PortalViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminSubscriptionBarViewComponent(
            IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string cssClass = "btn btn-icon btn-active-light-primary position-relative w-30px h-30px w-md-40px h-md-40px me-2")
        {
            var model = new SubscriptionBarViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                SubscriptionExpireNotifyDayCount = SettingManager.GetSettingValue<int>(AppSettings.TenantManagement.SubscriptionExpireNotifyDayCount),
                CssClass = cssClass
            };

            return View(model);
        }

    }
}
