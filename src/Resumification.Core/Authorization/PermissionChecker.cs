using Abp.Authorization;
using Resumification.Authorization.Roles;
using Resumification.Authorization.Users;

namespace Resumification.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
