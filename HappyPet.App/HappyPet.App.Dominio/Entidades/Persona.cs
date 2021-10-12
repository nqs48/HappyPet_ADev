using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
       // [Required, StringLength(30)] 
        public string Nombres { get; set; }
       // [Required, StringLength(30)]
        public string Apellidos { get; set; }
       // [Required, StringLength(15)]
         public string DocumentoIdentidad { get; set; }
       // [Required, StringLength(15)]
        public string Telefono { get; set; }
    
        public Persona()
            {
            }

        public Persona(int id, string nombres, string apellidos, string documentoIdentidad, string telefono)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            DocumentoIdentidad = documentoIdentidad;
            Telefono = telefono;
        }

    }
    

}