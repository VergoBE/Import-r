using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Importør.Pages.Car
{
    [Authorize(Roles = "Admin")]
    public class DeleteCarModel : PageModel
    {
        private CarService carService;

        public DeleteCarModel(CarService carService)
        {
            this.carService = carService;
        }

        [BindProperty] public Models.Car Car { get; set; }

        public IActionResult OnGet(int id)
        {
            Car = carService.GetCar(id);
            return Page();

        }
        public IActionResult OnPost(int id)
        {
            Car = carService.GetCar(id);
            Models.Car CarDeleted = carService.DeleteCar(id);
            return RedirectToPage("GetAllCars");
        }
    }
}
