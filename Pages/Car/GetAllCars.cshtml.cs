using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Importør.Pages.Car
{
    public class GetAllCarsModel : PageModel
    {
        //private CarService carService;

        public List<Models.Car> Cars { get; private set; }
        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public int MaxPrice { get; set; }
        [BindProperty] public int MinPrice { get; set; }

        //public void OnGet()
        //{
        //    Cars = carService.SortById().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortById()
        //{
        //    Cars = carService.SortById().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortByIdDescending()
        //{
        //    Cars = carService.SortByIdDescending().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortByName()
        //{
        //    Cars = carService.SortByName().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortByNameDescending()
        //{
        //    Cars = carService.SortByNameDescending().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortByPrice()
        //{
        //    Cars = carService.SortByPrice().ToList();
        //    return Page();
        //}

        //public IActionResult OnGetSortByPriceDescending()
        //{
        //    Cars = carService.SortByPriceDescending().ToList();
        //    return Page();
        //}

        //public IActionResult OnPostNameSearch()
        //{
        //    Cars = carService.NameSearch(SearchString).ToList();
        //    return Page();
        //}

        //public IActionResult OnPostPriceFilter(int maxPrice, int minPrice = 0)
        //{
        //    Cars = carService.PriceFilter(maxPrice, minPrice).ToList();
        //    return Page();
        //}
    }
}
