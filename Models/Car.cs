using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string FuelType { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }

        public Car(int id, string type, string fuelType, string model, string year, double price, string location)
        {
            Id = id;
            Type = type;
            FuelType = fuelType;
            Model = model;
            Year = year;
            Price = price;
            Location = location;
        }


    }
}
