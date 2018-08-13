using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskApp.Authorizations;
using TaskApp.Data;
using TaskApp.Model;

namespace TaskApp.Pages.TaskPages
{
    public class CreateModel : DI_BasePageModel
    {        
        public CreateModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<IdentityUser> userManager) : base(context, authorizationService, userManager)
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public task task { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            task.OwnerId = UserManager.GetUserId(User);
            var isAuthorized = await AuthorizationService.AuthorizeAsync(
            User, task, TaskOperations.Create);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            Context.tasks.Add(task);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");            
        }
    }
}