using ClassifiedAPI.DataAccess.DbContexts;
using ClassifiedAPI.Models.Dtos;
using ClassifiedAPI.Models.Models.Vehicle;
using ClassifiedAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAPI.Services.Services
{
    public class VehiclesService : IVehicleService
    {
        private VehicleDbContext _context = new VehicleDbContext();


        public List<VehicleDto> GetAllVehicles()
        {
            var vehicles = _context.Vehicles.ToList();

            var returnList = new List<VehicleDto>();

            foreach(var vehicle in vehicles)
            {
                returnList.Add(new VehicleDto
                {
                    Id = vehicle.Id,
                    Condition = vehicle.Condition,
                    Description = vehicle.Description,
                    EngineCapacity = vehicle.EngineCapacity,
                    FuelType = vehicle.FuelType,
                    Make = vehicle.Make,
                    ManufacturedYear = vehicle.ManufacturedYear,
                    Milage = vehicle.Milage,
                    Model = vehicle.Model,
                    Options = vehicle.Options,
                    OwnerPhone = vehicle.OwnerPhone,
                    RegisteredYear = vehicle.RegisteredYear,
                    Transmission = vehicle.Transmission,
                    Type = vehicle.Type
                }) ;
            }

            return returnList;
        }

        public VehicleDto AddVehicle(VehicleDto vehicleDto)
        {
            var vehicle = new Vehicle{

     
                Condition = vehicleDto.Condition,
                Description = vehicleDto.Description,
                EngineCapacity = vehicleDto.EngineCapacity,
                FuelType = vehicleDto.FuelType,
                Make = vehicleDto.Make,
                ManufacturedYear = vehicleDto.ManufacturedYear,
                Milage = vehicleDto.Milage,
                Model = vehicleDto.Model,
                Options = vehicleDto.Options,
                OwnerPhone = vehicleDto.OwnerPhone,
                RegisteredYear = vehicleDto.RegisteredYear,
                Transmission = vehicleDto.Transmission,
                Type = vehicleDto.Type
            };

            _context.Add(vehicle);
            _context.SaveChanges();

            return vehicleDto;
        }
    }
}
