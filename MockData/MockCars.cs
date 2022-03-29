using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;

namespace Importør.MockData
{
    public class MockCars
    {
        private static List<Car> cars = new List<Car>() {
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev"),
            new Car(1, "SUV", "Hybrid", "EQS", "2020", 800.000, "Haderslev")
         
        };


        public static List<Car> GetMockItems()
        {
            return cars;
        }
    }
}
