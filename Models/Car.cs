using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{
    public class Car
    {
        public int _id { get; set; }
        public string _type { get; set; }
        public string _fuelType { get; set; }
        public string _model { get; set; }
        public string _årgang { get; set; }
        public double _pris { get; set; }
        public string _lokation { get; set; }

        public Car(int id, string type, string fuelType, string model, string årgang, double pris, string lokation)
        {
            _id = id;
            _type = type;
            _fuelType = fuelType;
            _model = model;
            _årgang = årgang;
            _pris = pris;
            _lokation = lokation;
        }


    }
}