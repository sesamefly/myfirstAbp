using Abp.Authorization;
using MyFirstABP.Authorization.Roles;
using MyFirstABP.Authorization.Users;

namespace MyFirstABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
