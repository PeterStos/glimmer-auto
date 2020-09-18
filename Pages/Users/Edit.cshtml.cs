using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GlimmerAuto.Data;
using GlimmerAuto.Models;
using GlimmerAuto.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GlimmerAuto.Pages.Users
{
    [Authorize(Roles = SD.AdminEndUser)] // Password1!
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userFromDb = await _db.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);
            if(userFromDb == null)
            {
                return NotFound();
            }

            userFromDb.Name = ApplicationUser.Name;
            userFromDb.Address = ApplicationUser.Address;
            userFromDb.PhoneNumber = ApplicationUser.PhoneNumber;
            userFromDb.City = ApplicationUser.City;
            userFromDb.PostalCode = ApplicationUser.PostalCode;
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}