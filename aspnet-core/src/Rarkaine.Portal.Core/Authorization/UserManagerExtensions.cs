using System.Threading.Tasks;
using Abp.Authorization.Users;
using Rarkaine.Portal.Authorization.Users;

namespace Rarkaine.Portal.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
