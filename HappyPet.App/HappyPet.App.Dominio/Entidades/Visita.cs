using System;
namespace HappyPet.App.Dominio
{
    public class Visita{

        private DateTime FechaDeVisita {get;set;}
        private DateTime HoraDeVisita {get;set;}
        private Veterinario Veterinario {get;set;}
        private Mascota Mascota {get; set;}
    
    }
}