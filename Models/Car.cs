using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{    
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Location { get; set; }

        public Car(int carId, string type, string fuelType, string model, string year, double price, string location)
        {
            CarId = carId;
            Type = type;
            FuelType = fuelType;
            Model = model;
            Year = year;
            Price = price;
            Location = location;
        }


    }
}
