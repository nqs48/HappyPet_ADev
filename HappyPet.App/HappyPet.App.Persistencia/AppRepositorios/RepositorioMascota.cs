using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

      //METODO PARA RETORNAR TODOS LOS Mascotas
        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas.Include("Cliente").ToList();
        }
        
        //METODO PARA AGREGAR UNA MASCOTA SIN CLIENTE
        public Mascota AddMascota(Mascota mascota){
          
            var mascotaAdicionada= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        //METODO PARA AGREGAR UNA MASCOTA
        public Mascota AsignarCliente(Mascota mascota){
          _appContext.Entry(mascota).State=EntityState.Modified;
          _appContext.SaveChanges();
          return mascota;
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
                //mascotaEncontrada.Cliente= mascota.Cliente;
                _appContext.SaveChanges();
                
            }
            return mascotaEncontrada;
        }

        public Mascota UpdateAsignarCliente(Mascota mascota){
          _appContext.Entry(mascota).State=EntityState.Modified;
          _appContext.SaveChanges();
          return mascota;
        }
        


        
        
    }
}