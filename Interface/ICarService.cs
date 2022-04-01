using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;

namespace Importør.Interface
{
    interface ICarService
    {
        IEnumerable<Car> GetCars();
        void AddCar(Car car);
        IEnumerable<Car> CarSearch(string s);
        IEnumerable<Car> PriceSearch(int maxPrice, int minPrice = 0);
        IEnumerable<Car> FuelSearch(string fuel);
        void UpdateCar(Car car);
    }
}
