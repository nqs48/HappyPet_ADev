using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

using Microsoft.EntityFrameworkCore;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<HistoriaClinica> HistoriasClinicas{get;set;}
        public DbSet<Mascota> Mascotas{get;set;}
        public DbSet<Veterinario> Veterinarios{get;set;}
        public DbSet<Visita> Visitas{get;set;}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
                {
                  optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=HappyPetDataDB2;User ID=SA;Password=AmericanRocker");
                  //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= HappyPetDataDB");
                }
        }
     }
}