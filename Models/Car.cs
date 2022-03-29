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
        public string Årgang { get; set; }
        public double Pris { get; set; }
        public string Lokation { get; set; }

        public Car(int id, string type, string fuelType, string model, string årgang, double pris, string lokation)
        {
            Id = id;
            Type = type;
            FuelType = fuelType;
            Model = model;
            Årgang = årgang;
            Pris = pris;
            Lokation = lokation;
        }


    }
}
