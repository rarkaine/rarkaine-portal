using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Components.AdminRecentNotifications
{
    public class AdminRecentNotificationsViewComponent : PortalViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-alert-2 unread-notification fs-2")
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
