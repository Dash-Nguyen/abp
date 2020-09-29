using Abp.Authorization;
using gatling.Authorization.Roles;
using gatling.Authorization.Users;

namespace gatling.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
