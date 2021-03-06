using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;
using Importør.Interface;
using Importør.MockData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Importør.Services
{
    public class CarService
    {
        private List<Car> cars;
        private DbGenericService<Car> DbService { get; set; }
        public CarService(DbGenericService<Car> dbService)
        {
            cars = MockCars.GetMockCars();
            DbService = dbService;
            foreach(Car car in cars)
            {
                dbService.AddObjectAsync(car);
            }
            //insert json/DB injection here pls
        }
        public async Task AddCarAsync(Car car)
        {
            cars.Add(car);
            await DbService.AddObjectAsync(car);
            //Save Here When DB/json made
        }

        public IEnumerable<Car> CarSearch(string str)
        {

            List<Car> nameSearch = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Model.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(car);
                }
            }

            return nameSearch;
            //return from car in cars where car.Model.ToLower().Contains(s.ToLower()) select car;
        }

        public IEnumerable<Car> LocationSearch(string s)
        {
            List<Car> namesearch = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Location.ToLower().Contains(s.ToLower()))
                {
                    namesearch.Add(car);
                }
            }

            return namesearch;
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
        public Car GetCar(int id)
        {
            foreach(Car car in cars)
            {
                if (car.CarId == id) return car;
            }
            return null;
        }
        public IEnumerable<Car> PriceSearch(int maxPrice, int minPrice = 0)
        {
            List<Car> filterList = new List<Car>();
            foreach (Car car in cars)
            {
                if ((minPrice == 0 && car.Price <= maxPrice) || (maxPrice == 0 && car.Price >= minPrice) || (car.Price >= minPrice && car.Price <= maxPrice))
                {
                    filterList.Add(car);
                }
            }

            return filterList;
        }

        public async Task UpdateCarAsync(Car car)
        {
            if(car != null)
            {
                foreach(Car c in cars)
                {
                    if(c.CarId == car.CarId)
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
                await DbService.UpdateObjectAsync(car);
            }
        }
        public async Task DeleteCarAsync(int id)
        {
            Car carToDelete = null;
            foreach(Car car in cars)
            {
                if(car.CarId == id)
                {
                    carToDelete = car;
                    break;
                }
                if (carToDelete != null)
                {
                    await DbService.DeleteObjectAsync(carToDelete);

                }

            }
            
        }
    }
}
