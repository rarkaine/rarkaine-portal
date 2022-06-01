using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Permissions.Dto;

namespace Rarkaine.Portal.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}