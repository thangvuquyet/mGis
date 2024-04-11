using Abp.Authorization;
using mGISv3.Authorization.Roles;
using mGISv3.Authorization.Users;

namespace mGISv3.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
