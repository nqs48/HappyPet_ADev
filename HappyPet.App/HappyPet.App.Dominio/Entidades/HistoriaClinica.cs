using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class HistoriaClinica {
        public int Id {get;set;}
        public Visita Visita{get;set;}
        public double Peso {get;set;}
        public double Temperatura {get;set;}
        public double FrecuenciaRespiratoria {get;set;}
        public double FrecuenciaCardiaca {get;set;}

        [Required, StringLength(30)]
        public string EstadoDeSalud {get;set;}

        [Required, StringLength(150)]
        public string Obcervaciones {get;set;}
        

        public HistoriaClinica(int id, double peso, double temperatura, double frecuenciaRespiratoria, double frecuenciaCardiaca, string estadoDeSalud, string obcervaciones, Visita visita) 
        {
            this.Id= id;
            this.Peso= peso;
            this.Temperatura= temperatura;
            this.FrecuenciaRespiratoria= frecuenciaRespiratoria;
            this.FrecuenciaCardiaca= frecuenciaCardiaca;
            this.EstadoDeSalud= estadoDeSalud;
            this.Obcervaciones= obcervaciones;
            this.Visita= visita;    
        }

    public HistoriaClinica()
    {
    }
  }
}