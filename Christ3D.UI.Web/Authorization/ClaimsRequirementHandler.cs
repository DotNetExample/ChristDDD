using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Christ3D.Infrastruct.Identity.Authorization
{
    public class ClaimsRequirementHandler : AuthorizationHandler<ClaimRequirement>
    {

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ClaimRequirement requirement)
        {

            var roleId = context.User.Claims.FirstOrDefault(c => c.Type == "role");
            var rolename = context.User.Claims.FirstOrDefault(c => c.Type == "rolename");
            var loginUserName = context.User.Claims.FirstOrDefault(c => c.Type == "preferred_username");
            if (roleId != null && roleId.Value == "4" && rolename != null && rolename.Value == "SuperAdmin")
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}