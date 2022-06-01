using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Components.AdminChatToggler
{
    public class AdminChatTogglerViewComponent : PortalViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
