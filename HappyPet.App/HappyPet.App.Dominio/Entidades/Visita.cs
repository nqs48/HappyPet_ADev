using System;
namespace HappyPet.App.Dominio
{
    public class Visita{
        public int Id{get;set;}
        public DateTime FechaDeVisita {get;set;}
        public DateTime HoraDeVisita {get;set;}
        public Veterinario Veterinario {get;set;}
        public Mascota Mascota {get; set;}
        public Visita(int id, DateTime fechaDeVisita, DateTime horaDeVisita, Veterinario veterinario, Mascota mascota)
        {
            Id = id;
            FechaDeVisita = fechaDeVisita;
            HoraDeVisita = horaDeVisita;
            Veterinario = veterinario;
            Mascota = mascota;
        }

    public Visita()
    {
    }
  }
}