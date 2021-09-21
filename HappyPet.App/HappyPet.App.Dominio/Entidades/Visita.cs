using System;
namespace HappyPet.App.Dominio
{
    public class Visita{

        public DateTime FechaDeVisita {get;set;}
        public DateTime HoraDeVisita {get;set;}
        public Veterinario Veterinario {get;set;}
        public Mascota Mascota {get; set;}
    
    }
}