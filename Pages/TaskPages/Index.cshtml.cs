using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskApp.Authorizations;
using TaskApp.Data;
using TaskApp.Model;

namespace TaskApp.Pages.TaskPages
{
    public class IndexModel : DI_BasePageModel
    {
        public IndexModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<IdentityUser> userManager) : base(context, authorizationService, userManager)
        {
        }

        public IList<task> task { get; set; }

        public async Task OnGetAsync()
        {            
            var Tasks = from c in Context.tasks select c;
            var isAuthorized = User.IsInRole(Constants.TaskAdminRole);
            var currentUserId = UserManager.GetUserId(User);
            // Only tasks you're authorized to see are shown UNLESS you are admin.
            if (!isAuthorized)
            {
                Tasks = Tasks.Where(c => c.OwnerId == currentUserId);
            }
            task = await Tasks.ToListAsync();
        }
    }
}
