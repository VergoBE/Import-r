using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;
using Importør.Interface;
using Importør.MockData;

namespace Importør.Services
{
    public class CarService : ICarService
    {
        private List<Car> cars;
        public CarService()
        {
            cars = MockCars.GetMockCars();
            //insert json/DB injection here pls
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
            //Save Here When DB/json made
        }

        public IEnumerable<Car> CarSearch(string s)
        {
            foreach(Car car in cars)
            {
                if (car.Model == s) return cars;
            }
            return null;
        }

        public IEnumerable<Car> FuelSearch(string fuel)
        {
            foreach(Car car in cars)
            {
                if (car.FuelType == fuel) return cars;
            }
            return null;
        }

        public IEnumerable<Car> GetCars()
        {
            return cars;
        }

        public IEnumerable<Car> PriceSearch(int maxPrice, int minPrice = 0)
        {
            return from car in cars
                   where (minPrice == 0 && car.Pris <= maxPrice) ||
                      (maxPrice == 0 && car.Pris >= minPrice) ||
                      (car.Pris >= minPrice && car.Pris <= maxPrice)
                      select car;
        }
    }
}
