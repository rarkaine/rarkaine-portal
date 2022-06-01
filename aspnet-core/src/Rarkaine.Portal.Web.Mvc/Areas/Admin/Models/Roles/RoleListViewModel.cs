using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Authorization.Permissions.Dto;
using Rarkaine.Portal.Web.Areas.Admin.Models.Common;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}