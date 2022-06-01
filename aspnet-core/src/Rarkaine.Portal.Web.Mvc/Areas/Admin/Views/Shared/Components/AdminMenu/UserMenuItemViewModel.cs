using Abp.Application.Navigation;

namespace Rarkaine.Portal.Web.Areas.Admin.Views.Shared.Components.AdminMenu
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }

        public string CurrentPageName { get; set; }

        public int MenuItemIndex { get; set; }

        public int ItemDepth { get; set; }

        public bool RootLevel { get; set; }
        
        public bool IsTabMenuUsed { get; set; }
        
        public bool IconMenu { get; set; }
    }
}
