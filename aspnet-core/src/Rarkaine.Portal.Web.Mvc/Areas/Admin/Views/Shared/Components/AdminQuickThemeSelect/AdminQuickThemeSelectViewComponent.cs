using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rarkaine.Portal.Web.Areas.Admin.Models.Layout;
using Rarkaine.Portal.Web.Views;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Components.
    AdminQuickThemeSelect
{
    public class AdminQuickThemeSelectViewComponent : PortalViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
