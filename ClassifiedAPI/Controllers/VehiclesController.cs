using ClassifiedAPI.Models.Dtos;
using ClassifiedAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        public ActionResult GetVehicles()
        {
            var vehicles = _vehicleService.GetAllVehicles();
           //GenerateJWTToken();
            return Ok(vehicles);
        }
        [HttpPost]
        [Authorize]
        
        public ActionResult AddVehicle([FromBody] VehicleDto vehicleDto)
        {
            var vehicle = _vehicleService.AddVehicle(vehicleDto);
            return Ok(vehicle);
        }
        public string GenerateJWTToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Keysafafdgdgdgdgdgdgdgdrgdg"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,"Samesh"),
                new Claim(JwtRegisteredClaimNames.Email,"buddikasamesh1@gmail.com"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken
                (
                   issuer : "Samesh",
                   audience:"All",
                   claims,
                   expires : DateTime.Now.AddDays(1),
                   signingCredentials : credentials
                );

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return encodedToken;
        }

    }
}
