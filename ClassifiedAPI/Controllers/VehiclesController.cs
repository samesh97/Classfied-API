using ClassifiedAPI.Models.Dtos;
using ClassifiedAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassifiedAPI.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IVehicleService _vehicleService;
        public VehiclesController(IVehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        [HttpGet]
        public ActionResult GetVehicles()
        {
            var vehicles = _vehicleService.GetAllVehicles();
            return Ok(vehicles);
        }
        [HttpPost]
        public ActionResult AddVehicle([FromBody] VehicleDto vehicleDto)
        {
            var vehicle = _vehicleService.AddVehicle(vehicleDto);
            return Ok(vehicle);
        }

    }
}
