using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlimmerAuto.Data;
using GlimmerAuto.Models;
using GlimmerAuto.Models.ViewModel;
using GlimmerAuto.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GlimmerAuto.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private int productPage;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        //public List<ApplicationUser> ApplicationUserList { get; set; }
        public UsersListViewModel UsersListVM { get; set; }

        public async Task<IActionResult> OnGet(int productPage = 1)
        {
            UsersListVM = new UsersListViewModel()
            {
                ApplicationUserList = await _db.ApplicationUser.ToListAsync()

            };

            StringBuilder param = new StringBuilder();
            param.Append("/Users?productPage=:"); // append the url and users
            var count = UsersListVM.ApplicationUserList.Count;

            UsersListVM.PageInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = SD.PaginationUsersPageSize,
                TotalItems = count,
                UrlParam = param.ToString()
            };

            UsersListVM.ApplicationUserList = UsersListVM.ApplicationUserList.OrderBy(p => p.Email)
                .Skip((productPage - 1) * SD.PaginationUsersPageSize)  // 
                .Take(SD.PaginationUsersPageSize).ToList();

            return Page();  
        }
    }
}