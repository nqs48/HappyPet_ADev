using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public class RepositorioVisita : IRepositorioVisita
    {
      private readonly AppContext _appContext;

      public RepositorioVisita(AppContext appContext)
        {
          _appContext= appContext;
        }

        
        // METODOS CRUD Visita

        //METODO PARA AGREGAR UN Visita
        public Visita AddVisita(Visita visita){
            var visitaAdicionada= _appContext.Visitas.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionada.Entity;
        }

        public Visita AsignarMascota(Visita visita){
          _appContext.Entry(visita).State=EntityState.Modified;
          _appContext.SaveChanges();
          return visita;
        }

        public Visita AsignarVeterinario(Visita visita){
          _appContext.Entry(visita).State=EntityState.Modified;
          _appContext.SaveChanges();
          return visita;
        }

        //METODO PARA ELIMINAR Visita
        public Visita DeleteVisita(int idVisita)
        {
            var visitaEncontrada=_appContext.Visitas.FirstOrDefault(v => v.Id==idVisita);
            if (visitaEncontrada==null)
                return null;
            _appContext.Visitas.Remove(visitaEncontrada);
            _appContext.SaveChanges();
            return visitaEncontrada;
        }

        //METODO PARA RETORNAR TODOS LOS Visitas
        public IEnumerable<Visita> GetAllVisitas()
        {
            return _appContext.Visitas;
        }

        //METODO PARA RETORNAR UN Visita
        public Visita GetVisita(int idVisita)
        {
            var visitaEncontrada=_appContext.Visitas.FirstOrDefault(v => v.Id ==idVisita);
            return visitaEncontrada;
           
        }

        //METODO PARA ACTUALIZAR UN Visita
        public Visita UpdateVisita(Visita visita)
        {
            var visitaEncontrada=_appContext.Visitas.FirstOrDefault(v => v.Id==visita.Id);
            if(visitaEncontrada!=null)
            {
                visitaEncontrada.FechaDeVisita= visita.FechaDeVisita;
                //visitaEncontrada.HoraDeVisita= visita.HoraDeVisita;
                //visitaEncontrada.Veterinario= visita.Veterinario;
                //visitaEncontrada.Mascota= visita.Mascota;

                _appContext.SaveChanges();
                
            }
            return visitaEncontrada;
        }
    }
}