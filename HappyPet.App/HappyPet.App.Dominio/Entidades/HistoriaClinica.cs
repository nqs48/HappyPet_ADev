using System;
namespace HappyPet.App.Dominio
{
    public class HistoriaClinica{
        public int ID {get;set;}
        public double Peso {get;set;}
        public double temperatura {get;set;}
        public double FrecuenciaRespiratoria {get;set;}
        public double FrecuenciaCardiaca {get;set;}
        public string EstadoDeSalud {get;set;}
        public Mascota Mascota{get;set;}
        public Visita Visita{get;set;}

    }
}