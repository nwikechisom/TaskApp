using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskApp.Data;
using TaskApp.Model;

namespace TaskApp.Pages.TaskPages
{
    public class DetailsModel : PageModel
    {
        private readonly TaskApp.Data.ApplicationDbContext _context;

        public DetailsModel(TaskApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public task task { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            task = await _context.tasks.FirstOrDefaultAsync(m => m.taskId == id);

            if (task == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
