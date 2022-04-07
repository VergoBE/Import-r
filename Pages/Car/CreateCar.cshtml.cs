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
        private CarService _carService;
        private List<Models.Car> cars;

        public CreateCarModel(CarService carService)
        {
            _carService = carService;
            cars = carService.GetCars().ToList();
            
        }
        

      [BindProperty]  public Models.Car Car { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _carService.AddCarAsync(Car);
            
            return RedirectToPage("/GetAllCars");
        }

    }
}
