using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPet.App.Dominio
{
    public class Cliente : Persona
    {  
        [Required, StringLength(40)] 
        public string Direccion {set; get;}
        
        public Cliente()
        {
        }
        
        public Cliente(int id, string nombres, string apellidos, string documentoIdentidad, string telefono ,string direccion) : base(id,nombres,apellidos,documentoIdentidad,telefono)
        {         
            Direccion = direccion;
            this.Id=id;
            this.Nombres= nombres;
            this.Apellidos= apellidos;
            this.DocumentoIdentidad= documentoIdentidad;
            this.Telefono= telefono;    
       }
    }
}