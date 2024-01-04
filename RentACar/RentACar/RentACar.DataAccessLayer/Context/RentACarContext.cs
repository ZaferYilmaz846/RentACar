using Microsoft.EntityFrameworkCore;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DataAccessLayer.Context
{
    public class RentACarContext : DbContext
    {
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0LOVGSG;Database=RentACar;Trusted_Connection=True;");
        }
    }
}
