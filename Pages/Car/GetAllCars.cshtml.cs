using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.MockData;
using Importør.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace Importør.Pages.Car
{
    public class GetAllCarsModel : PageModel
    {
        private CarService carService;
        public List<Models.Car> Cars { get; private set; }
        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public int MaxPrice { get; set; }
        [BindProperty] public int MinPrice { get; set; }

        public GetAllCarsModel(CarService carService) //Dependency Injection
        {
            this.carService = carService;
        }

        public IActionResult OnGet()
        {
            Cars = carService.GetCars().ToList();
            return Page();
        }

        public async void AddCar(Models.Car car)
        {
            Cars.Add(car);

            //await Dbservice.AddÓbjectAsync(car);
        }

        public IActionResult PriceSearch(int maxPrice, int minPrice)
        {
            Cars = carService.PriceSearch(maxPrice, minPrice).ToList();
            return Page();
        }

        public IActionResult FuelSearch(string fuel)
        {
            Cars = carService.FuelSearch(fuel).ToList();
            return Page();
        }

        public IActionResult CarSearch(string s)
        {
            Cars = carService.CarSearch(s).ToList();
            return Page();
        }
        
    }
}
