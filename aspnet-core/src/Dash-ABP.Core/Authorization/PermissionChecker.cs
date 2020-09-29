using Abp.Authorization;
using Dash-ABP.Authorization.Roles;
using Dash-ABP.Authorization.Users;

namespace Dash-ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
