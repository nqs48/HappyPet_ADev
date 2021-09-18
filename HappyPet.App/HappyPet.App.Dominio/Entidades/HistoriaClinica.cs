using System;
namespace HappyPet.App.Dominio
{
    public class HistoriaClinica{
        private int ID {get;set;}
        private double Peso {get;set;}
        private double temperatura {get;set;}
        private double FrecuenciaRespiratoria {get;set;}
        private double FrecuenciaCardiaca {get;set;}
        private string EstadoDeSalud {get;set;}
        private Mascota Mascota{get;set;}
        private Visita Visita{get;set;}

    }
}