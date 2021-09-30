using System;
namespace HappyPet.App.Dominio
{
    public class Veterinario : Persona
    {
        public Veterinario(int tarjetaProfesional,int id, string nombres, string apellidos, string documentoIdentidad, string telefono)
        {
            TarjetaProfesional = tarjetaProfesional;
            this.Nombres= nombres;
            this.Apellidos= apellidos;
            
        }

        public int TarjetaProfesional { get; set; }

    }
}