using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Rarkaine.Portal.Authorization.Users;
using Rarkaine.Portal.MultiTenancy;

namespace Rarkaine.Portal.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}