using Microsoft.EntityFrameworkCore;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia
{ 
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UserSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog= HappyPetData");
        }
    } 

    }
}    