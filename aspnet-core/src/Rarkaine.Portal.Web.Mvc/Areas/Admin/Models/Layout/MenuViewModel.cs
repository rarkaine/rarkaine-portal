using Abp.Application.Navigation;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string Height { get; set; }
        
        public string CurrentPageName { get; set; }
        
        public bool IconMenu { get; set; }
    }
}
