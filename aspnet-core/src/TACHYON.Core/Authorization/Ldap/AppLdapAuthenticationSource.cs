﻿using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using TACHYON.Authorization.Users;
using TACHYON.MultiTenancy;

namespace TACHYON.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}