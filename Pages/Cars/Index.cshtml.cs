using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GlimmerAuto.Data;
using GlimmerAuto.Models.ViewModel;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using GlimmerAuto.Models;
using Microsoft.AspNetCore.Authorization;

namespace GlimmerAuto.Pages.Cars
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty] 
        public CarAndCustomerViewModel CarAndCustomerVM { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        //public ApplicationUser UserObj { get; private set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGet(string userId = null)
        {
            if (userId == null)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                userId = claim.Value;
            }

            CarAndCustomerVM = new CarAndCustomerViewModel()
            {
                Cars = await _db.Car.Where(c => c.UserId == userId).ToListAsync(),
                UserObj = await _db.ApplicationUser.FirstOrDefaultAsync(u => u.Id == userId)
            };

            return Page();
        }
    }
}