using System;
namespace HappyPet.App.Dominio
{
    public class Mascota{
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}
        public Cliente Cliente{get;set;}
    }
}
    