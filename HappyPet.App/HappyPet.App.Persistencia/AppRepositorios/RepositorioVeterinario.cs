using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
      private readonly AppContext _appContext;

      public RepositorioVeterinario(AppContext appContext)
        {
          _appContext= appContext;
        }

        
        // METODOS CRUD Veterinario

        //METODO PARA AGREGAR UN Veterinario
        public Veterinario AddVeterinario(Veterinario veterinario){
            var veterinarioAdicionado= _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        //METODO PARA ELIMINAR Veterinario
        public Veterinario DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id==idVeterinario);
            if (veterinarioEncontrado==null)
                return null;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
            return veterinarioEncontrado;
        }

        //METODO PARA RETORNAR TODOS LOS Veterinarios
        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        //METODO PARA RETORNAR UN Veterinario
        public Veterinario GetVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id ==idVeterinario);
            return veterinarioEncontrado;
           
        }

        //METODO PARA ACTUALIZAR UN Veterinario
        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id==veterinario.Id);
            if(veterinarioEncontrado!=null)
            {
                veterinarioEncontrado.Nombres= veterinario.Nombres;
                veterinarioEncontrado.Apellidos= veterinario.Apellidos;
                veterinarioEncontrado.DocumentoIdentidad= veterinario.DocumentoIdentidad;
                veterinarioEncontrado.Telefono= veterinario.Telefono;
                veterinarioEncontrado.TarjetaProfesional= veterinario.TarjetaProfesional;

                _appContext.SaveChanges();
                
            }
            return veterinarioEncontrado;
        }
        
    }
}              