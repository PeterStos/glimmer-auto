using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlimmerAuto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GlimmerAuto
{
    public class CreateModel : PageModel
    {
        public ServiceType ServiceType { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}