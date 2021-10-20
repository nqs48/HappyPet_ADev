using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class Visita{
        public int Id{get;set;}
        public DateTime FechaDeVisita {get;set;}
        public Veterinario Veterinario {get;set;}
        public Mascota Mascota {get; set;}
        
        public Visita(int id, DateTime fechaDeVisita, Veterinario veterinario, Mascota mascota)
        {
            Id = id;
            FechaDeVisita = fechaDeVisita;
            Veterinario = veterinario;
            Mascota = mascota;
        }

    public Visita()
    {
    }
  }
}