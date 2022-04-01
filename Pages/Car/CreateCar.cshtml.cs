using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Importør.Services;
using Importør.Models;
using Microsoft.AspNetCore.Authorization;

namespace Importør.Pages.Car
{
    [Authorize(Roles = "Admin")]
    public class CreateCarModel : PageModel
    {
        private CarService carService;
        private List<Models.Car> carList;

        public CreateCarModel(CarService carService)
        {
            this.carService = carService;
            carList = carService.GetCars().ToList();
        }

        public Models.Car Car { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            carService.AddCar(Car);
            return RedirectToPage("GetAllCars");
        }

    }
}
