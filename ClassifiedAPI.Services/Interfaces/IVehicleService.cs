﻿using ClassifiedAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAPI.Services.Interfaces
{
    public interface IVehicleService
    {
        List<VehicleDto> GetAllVehicles();
        VehicleDto AddVehicle(VehicleDto vehicleDto);
    }
}
