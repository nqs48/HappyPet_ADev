using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class Mascota{
        public int Id {get;set;}

        [Required, StringLength(25)]
        public string Nombre {get;set;}
        
        [Required, StringLength(20)]
        public string Especie {get;set;}
        
        [Required, StringLength(20)]
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
    