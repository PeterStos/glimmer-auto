﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlimmerAuto.Data;
using GlimmerAuto.Models;
using GlimmerAuto.Models.ViewModel;
using GlimmerAuto.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GlimmerAuto.Pages.Services
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CarServiceViewModel CarServiceVM { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGetAsync(int carId)
        {
            CarServiceVM = new CarServiceViewModel
            {
                Car = await _db.Car.Include(c=>c.ApplicationUser).FirstOrDefaultAsync(c=>c.Id == carId),
                ServiceHeader = new ServiceHeader()
            };

            // Retrieve all the ServiceType from the ServiceShoppingCart
            // List of Shopping Cart from the database from the ShoppingCart table for that particular car
            List<String> lstServiceTypeInShoppingCart = _db.ServiceShoppingCart
                .Include(c => c.ServiceType)
                .Where(c => c.CarId == carId)
                .Select(c => c.ServiceType.Name).ToList();

            // Retrieve the service for the dropdown
            IQueryable<ServiceType> lstService = from s in _db.ServiceType
                                                 where !(lstServiceTypeInShoppingCart.Contains(s.Name))
                                                 select s;


            CarServiceVM.ServiceTypesList = lstService.ToList();
            // Retrieve the ServiceShoppingCar
            CarServiceVM.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.CarId == carId).ToList();
            CarServiceVM.ServiceHeader.TotalPrice = 0;

            foreach(var item in CarServiceVM.ServiceShoppingCart)
            {
                CarServiceVM.ServiceHeader.TotalPrice += item.ServiceType.Price;
            }

            return Page();
        }
    }
}