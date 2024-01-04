using Microsoft.EntityFrameworkCore;
using RentACar_MVC_UI.Models.Entities;

namespace RentACar_MVC_UI.Database
{
    public class ContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0LOVGSG;Database=RentACar;Trusted_Connection=True;");
        }
    }
}
