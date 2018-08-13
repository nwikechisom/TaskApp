using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using TaskApp.Model;

namespace TaskApp.Authorizations
{
    public class TaskEmpAuthHandler : AuthorizationHandler<OperationAuthorizationRequirement, task>
    {
        UserManager<IdentityUser> _userManager;
        public TaskEmpAuthHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, task resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }
            // If we're not asking for CRUD permission, return.
            if (requirement.Name != Constants.CreateOperationName &&
            requirement.Name != Constants.ReadOperationName &&
            requirement.Name != Constants.UpdateOperationName &&
            requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (resource.OwnerId == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}