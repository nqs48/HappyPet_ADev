using System;
namespace HappyPet.App.Dominio
{
    public class Persona{
        public Persona(int id, string nombres, string apellidos, string documentoIdentidad, string telefono) 
        {
                this.Id = id;
                this.Nombres = nombres;
                this.Apellidos = apellidos;
                this.DocumentoIdentidad = documentoIdentidad;
                this.Telefono = telefono;
               
        }
        public int Id{get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string DocumentoIdentidad {get;set;}
        public string Telefono {get;set;}

    }
}