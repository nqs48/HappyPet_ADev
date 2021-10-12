using System;
namespace HappyPet.App.Dominio
{
    public class HistoriaClinica {
        public int Id {get;set;}
        public double Peso {get;set;}
        public double temperatura {get;set;}
        public double FrecuenciaRespiratoria {get;set;}
        public double FrecuenciaCardiaca {get;set;}
        public string EstadoDeSalud {get;set;}
        public Mascota Mascota{get;set;}
        public Visita Visita{get;set;}
        public HistoriaClinica(int id, double peso, double temperatura, double frecuenciaRespiratoria, double frecuenciaCardiaca, string estadoDeSalud, Mascota mascota, Visita visita) 
        {
            this.Id= id;
            this.Peso= peso;
            this.temperatura= temperatura;
            this.FrecuenciaRespiratoria= frecuenciaRespiratoria;
            this.FrecuenciaCardiaca= frecuenciaCardiaca;
            this.EstadoDeSalud= estadoDeSalud;
            this.Mascota= mascota;
            this.Visita= visita;    
        }
    }
}