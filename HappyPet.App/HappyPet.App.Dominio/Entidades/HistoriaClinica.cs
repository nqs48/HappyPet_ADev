using System;
namespace HappyPet.App.Dominio
{
    public class HistoriaClinica {
        public int Id {get;set;}
        public Mascota Mascota{get;set;}
        public double Peso {get;set;}
        public double Temperatura {get;set;}
        public double FrecuenciaRespiratoria {get;set;}
        public double FrecuenciaCardiaca {get;set;}
        public string EstadoDeSalud {get;set;}
        public Visita Visita{get;set;}

        public HistoriaClinica(int id, Mascota mascota, double peso, double temperatura, double frecuenciaRespiratoria, double frecuenciaCardiaca, string estadoDeSalud, Visita visita) 
        {
            this.Id= id;
            this.Mascota= mascota;
            this.Peso= peso;
            this.Temperatura= temperatura;
            this.FrecuenciaRespiratoria= frecuenciaRespiratoria;
            this.FrecuenciaCardiaca= frecuenciaCardiaca;
            this.EstadoDeSalud= estadoDeSalud;
            this.Visita= visita;    
        }

    public HistoriaClinica()
    {
    }
  }
}