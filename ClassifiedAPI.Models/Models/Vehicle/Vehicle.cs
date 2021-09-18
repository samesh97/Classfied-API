using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAPI.Models.Models.Vehicle
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public int Milage { get; set; }
        [Required]
        public int ManufacturedYear { get; set; }
        [Required]
        public int RegisteredYear { get; set; }
        [Required]
        public int EngineCapacity { get; set; }
        [Required]
        public string Options { get; set; }
        public string Description { get; set; }

        [Required]
        [MaxLength(10)]
        public string OwnerPhone { get; set; }


    }
}
