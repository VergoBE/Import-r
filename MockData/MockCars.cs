using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;

namespace Importør.MockData
{
    public class MockCars
    {
        private static List<Car> cars = new List<Car>()
        {
            new Car(1, "Sport", "Benzin", "AMG C63", "2021", 1000000, "Roskilde"),
            new Car(2, "SUV", "E", "G 63 AMG", "2021", 5000000, "Roskilde"),
            new Car(3, "Cabriolet", "Diesel", "SL Roadster", "2021", 2000000, "Roskilde"),
            new Car(4, "Sedan", "E", "A 250 e Sedan", "2021", 500000, "Roskilde"),
        };

        public static List<Car> GetMockCars()
        {
            return cars;
        }
    }
}
