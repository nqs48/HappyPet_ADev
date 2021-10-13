using System;
namespace HappyPet.App.Dominio
{
    public class Mascota{
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}
        public Cliente Cliente{get;set;}
        
        public Mascota(int id, string nombre, string especie, string raza, Cliente cliente){
            Id = id;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Cliente = cliente;  
        }

        public Mascota()
        {
        }
  }
}
    