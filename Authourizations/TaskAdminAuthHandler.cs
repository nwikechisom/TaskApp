using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using TaskApp.Model;

namespace TaskApp.Authorizations
{
    public class TaskAdminAuthHandler : AuthorizationHandler<OperationAuthorizationRequirement, task>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, task resource)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }
            // Administrators can do anything.
            if (context.User.IsInRole(Constants.TaskAdminRole))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}