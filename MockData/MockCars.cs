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
            new Car(1, "Sport", "Hybrid", "AMG C63", "2021", 2000000, "Roskilde"),
            new Car(1, "Sport", "Hybrid", "AMG C63", "2021", 2000000, "Roskilde"),
            new Car(1, "Sport", "Hybrid", "AMG C63", "2021", 2000000, "Roskilde"),
            new Car(1, "Sport", "Hybrid", "AMG C63", "2021", 2000000, "Roskilde"),
        };

        public static List<Car> GetMockCars()
        {
            return cars;
        }
    }
}
