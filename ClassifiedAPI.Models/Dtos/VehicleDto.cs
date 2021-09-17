using ClassifiedAPI.Models.Models.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAPI.Models.Dtos
{
    public class VehicleDto
    {
        public int Id { get; set; }
    
        public VehicleMake Make { get; set; }
     
        public string Model { get; set; }
     
        public VehicleType Type { get; set; }
 
        public VehicleCondition Condition { get; set; }
     
        public VehicleTransmission Transmission { get; set; }
    
        public VehicleFuelType FuelType { get; set; }
 
        public int Milage { get; set; }
     
        public int ManufacturedYear { get; set; }
  
        public int RegisteredYear { get; set; }
   
        public int EngineCapacity { get; set; }
    
        public string Options { get; set; }
        public string Description { get; set; }

        public string OwnerPhone { get; set; }
    }
}
