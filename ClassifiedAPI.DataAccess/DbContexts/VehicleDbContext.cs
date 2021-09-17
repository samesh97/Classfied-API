using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassifiedAPI.Models.Models.Vehicle;
using Microsoft.EntityFrameworkCore;

namespace ClassifiedAPI.DataAccess.DbContexts
{
    public class VehicleDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Classified;Integrated Security=True";
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
