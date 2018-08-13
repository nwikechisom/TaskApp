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
                    taskTitle = "Have Sex",
                    taskDescription = "Slide in your dick in the ass and ride back and forth",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Fetch Water",
                    taskDescription = "Get to the borehole and put on the tap",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Sing a song",
                    taskDescription = "Open your mouth and make a beautiful sound from the depths of your belly",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Eat food",
                    taskDescription = "Take a spoon, lift a portion of the food into your mouth, slowly so as to not choke",
                    OwnerId = adminID
                },
                new task
                {
                    taskTitle = "Get a job",
                    taskDescription = "send an application to a firm of your choice",
                    OwnerId = adminID
                }
             );
            context.SaveChanges();
        }
    }
}