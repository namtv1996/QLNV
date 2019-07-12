using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using CRM.Authorization.Users;
using CRM.MultiTenancy;

namespace CRM.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}