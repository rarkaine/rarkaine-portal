using Abp.Authorization;
using Rarkaine.Portal.Authorization.Roles;
using Rarkaine.Portal.Authorization.Users;

namespace Rarkaine.Portal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
