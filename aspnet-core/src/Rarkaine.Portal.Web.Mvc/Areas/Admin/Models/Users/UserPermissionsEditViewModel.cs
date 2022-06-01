using Abp.AutoMapper;
using Rarkaine.Portal.Authorization.Users;
using Rarkaine.Portal.Authorization.Users.Dto;
using Rarkaine.Portal.Web.Areas.Admin.Models.Common;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}