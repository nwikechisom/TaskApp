using System;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace TaskApp.Authorizations
{
    public static class TaskOperations
    {
        public static OperationAuthorizationRequirement Create = new OperationAuthorizationRequirement { Name = Constants.CreateOperationName };

            public static OperationAuthorizationRequirement Read = new OperationAuthorizationRequirement { Name = Constants.ReadOperationName };

            public static OperationAuthorizationRequirement Update = new OperationAuthorizationRequirement { Name = Constants.UpdateOperationName };

            public static OperationAuthorizationRequirement Delete = new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };

            public static OperationAuthorizationRequirement Assign = new OperationAuthorizationRequirement { Name = Constants.AssignOperationName };
    }
    public class Constants
        {
            public static readonly string CreateOperationName = "Create";
            public static readonly string ReadOperationName = "Read";
            public static readonly string UpdateOperationName = "Update";
            public static readonly string DeleteOperationName = "Delete";
            public static readonly string AssignOperationName = "Assign";

            public static readonly string TaskAdminRole = "TaskAdmin";

            public static readonly string TaskEmpRole = "TaskEmp";
        }
}