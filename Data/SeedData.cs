using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.Authorizations;
using TaskApp.Model;

namespace TaskApp.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //SeedDB(context, "0");

                var adminID = await EnsureUser(serviceProvider, testUserPw, "admin@acclio.com");
                await EnsureRole(serviceProvider, adminID, Constants.TaskAdminRole);

                var empID = await EnsureUser(serviceProvider, testUserPw, "employee@acclio.com");
                await EnsureRole(serviceProvider, empID, Constants.TaskEmpRole);

                SeedDB(context, adminID);
            }
        }

        private static async Task<string> EnsureUser(IServiceProvider serviceProvider, string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new IdentityUser { UserName = UserName };
                await userManager.CreateAsync(user, testUserPw);
            }
            return user.Id;
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider, string uid, string role)
        {
            IdentityResult IR = null;
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            if (!await roleManager.RoleExistsAsync(role))
            {
                IR = await roleManager.CreateAsync(new IdentityRole(role));
            }
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
            var user = await userManager.FindByIdAsync(uid);
            IR = await userManager.AddToRoleAsync(user, role);
            return IR;
        }

        

        public static void SeedDB(ApplicationDbContext context, string adminID)
        {
            if (context.tasks.Any())
            {
                return;   // DB has been seeded
            }

            context.tasks.AddRange(
                new task
                {
                    taskTitle = "Create Flow Chart",
                    taskDescription = "Build A flow network for the proposed app",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Creatw APIs",
                    taskDescription = "Work with the flow chart and create API",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "UI Design",
                    taskDescription = "Build a wireframe for the proposed project",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Build UI",
                    taskDescription = "Implement the wireframe using frontend development tools",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Call APIs",
                    taskDescription = "using frontend frameworks call the created APIs into the UI",
                    OwnerId = adminID
                }
             );
            context.SaveChanges();
        }
    }
}
