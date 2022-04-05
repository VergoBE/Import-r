using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Importør.Pages.Car
{
    public class CarLocationsModel : PageModel
    {
        private CarService carService;
        public List<Models.Car> Cars { get; private set; }
        [BindProperty] public string SearchString { get; set; }

        public CarLocationsModel(CarService carService) //Dependency Injection
        {
            this.carService = carService;
        }

        public IActionResult OnGet()
        {
            Cars = carService.GetCars().ToList();
            return Page();
        }

        public IActionResult OnPostLocationSearch(string s)
        {
            Cars = carService.LocationSearch(s).ToList();
            return Page();
        }
    }
}
