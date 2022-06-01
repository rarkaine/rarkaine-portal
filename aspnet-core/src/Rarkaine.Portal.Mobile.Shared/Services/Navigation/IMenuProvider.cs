using System.Collections.Generic;
using MvvmHelpers;
using Rarkaine.Portal.Models.NavigationMenu;

namespace Rarkaine.Portal.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}