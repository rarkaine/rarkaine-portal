using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Permissions.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}