using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Delegation;
using Rarkaine.Portal.Authorization.Users.Delegation.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
