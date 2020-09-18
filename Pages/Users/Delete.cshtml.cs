using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlimmerAuto.Data;
using GlimmerAuto.Models;
using GlimmerAuto.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GlimmerAuto.Pages.Users
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id.Trim().Length == 0)
            {
                return NotFound();
            }

            ApplicationUser = await _db.ApplicationUser.SingleOrDefaultAsync(m => m.Id == id);

            if (ApplicationUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ApplicationUser == null)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);

            _db.Users.Remove(userFromDb);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}