using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
      private readonly AppContext _appContext;

      public RepositorioMascota(AppContext appContext)
        {
          _appContext= appContext;
        }

        
        // METODOS CRUD MASCOTA

        //METODO PARA AGREGAR UN Mascota
        public Mascota AddMascota(Mascota mascota){
            var mascotaAdicionada= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        //METODO PARA ELIMINAR Mascota
        public Mascota DeleteMascota(int idMascota)
        {
            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(c => c.Id==idMascota);
            if (mascotaEncontrada==null)
                return null;
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
            return mascotaEncontrada;
        }

        //METODO PARA RETORNAR TODOS LOS Mascotas
        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        //METODO PARA RETORNAR UN Mascota
        public Mascota GetMascota(int idMascota)
        {
            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(c => c.Id==idMascota);
            return mascotaEncontrada;
           
        }

        //METODO PARA ACTUALIZAR UN Mascota
        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(c => c.Id==mascota.Id);
            if(mascotaEncontrada!=null)
            {
                mascotaEncontrada.Nombre= mascota.Nombre;
                mascotaEncontrada.Especie= mascota.Especie;
                mascotaEncontrada.Raza= mascota.Raza;
                mascotaEncontrada.Cliente= mascota.Cliente;

                _appContext.SaveChanges();
                
            }
            return mascotaEncontrada;
        }
        
    }
}