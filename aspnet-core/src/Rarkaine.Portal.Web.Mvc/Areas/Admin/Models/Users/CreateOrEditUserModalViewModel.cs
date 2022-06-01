using System.Linq;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Rarkaine.Portal.Authorization.Users.Dto;
using Rarkaine.Portal.Security;
using Rarkaine.Portal.Web.Areas.Admin.Models.Common;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Users
{
    [AutoMapFrom(typeof(GetUserForEditOutput))]
    public class CreateOrEditUserModalViewModel : GetUserForEditOutput, IOrganizationUnitsEditViewModel
    {
        public bool CanChangeUserName => User.UserName != AbpUserBase.AdminUserName;

        public int AssignedRoleCount
        {
            get { return Roles.Count(r => r.IsAssigned); }
        }

        public bool IsEditMode => User.Id.HasValue;

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }
    }
}