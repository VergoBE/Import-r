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

            if (string.IsNullOrEmpty(s)) return cars;
            return cars.FindAll(Car => Car.Model.ToLower().Contains(s.ToLower()));
            //return from car in cars where car.Model.ToLower().Contains(s.ToLower()) select car;
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
                   where (minPrice == 0 && car.Price <= maxPrice) ||
                      (maxPrice == 0 && car.Price >= minPrice) ||
                      (car.Price >= minPrice && car.Price <= maxPrice)
                      select car;
        }
        public void UpdateCar(Car car)
        {
            if(car != null)
            {
                foreach(Car c in cars)
                {
                    if(c.Id == car.Id)
                    {
                        c.Model = car.Model;
                        c.Price = car.Price;
                        c.Type = car.Type;
                        c.Year = car.Year;
                        c.Location = car.Location;
                        c.FuelType = car.FuelType;
                    }
                    //Insert Save method here for DB
                }
            }
        }
    }
}
