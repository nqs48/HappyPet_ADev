using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class Veterinario : Persona
    {
        public int TarjetaProfesional { get; set; }

        public Veterinario(int id, string nombres, string apellidos, string documentoIdentidad, string telefono,int tarjetaProfesional) : base(id,nombres,apellidos,documentoIdentidad,telefono)
        {
            this.Id=id;
            this.Nombres= nombres;
            this.Apellidos= apellidos;
            this.DocumentoIdentidad= documentoIdentidad;
            this.Telefono= telefono;
            TarjetaProfesional = tarjetaProfesional;
        }

    public Veterinario()
    {
      
    }
  }
}