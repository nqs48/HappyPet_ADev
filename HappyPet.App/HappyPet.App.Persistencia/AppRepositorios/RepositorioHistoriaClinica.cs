using System;
using System.Collections.Generic;
using HappyPet.App.Dominio;
using System.Linq;


namespace HappyPet.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica 
    {
        private readonly AppContext _appContext;

      public RepositorioHistoriaClinica(AppContext appContext)
        {
          _appContext= appContext;
        }

        
        // METODOS CRUD Historia

        //METODO PARA AGREGAR UN Historia
        public HistoriaClinica AddHistoria(HistoriaClinica historia){
            var historiaAdicionada= _appContext.HistoriasClinicas.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }

        //METODO PARA ELIMINAR Historia
        public HistoriaClinica DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada=_appContext.HistoriasClinicas.FirstOrDefault(c => c.Id==idHistoria);
            if (historiaEncontrada==null)
                return null;
            _appContext.HistoriasClinicas.Remove(historiaEncontrada);
            _appContext.SaveChanges();
            return historiaEncontrada;
        }

        //METODO PARA RETORNAR TODOS LOS HistoriaS
        public IEnumerable<HistoriaClinica> GetAllHistorias()
        {
            return _appContext.HistoriasClinicas;
        }

        //METODO PARA RETORNAR UN Historia
        public HistoriaClinica GetHistoria(int idHistoria)
        {
            var historiaEncontrada=_appContext.HistoriasClinicas.FirstOrDefault(c => c.Id==idHistoria);
            return historiaEncontrada;
           
        }

        //METODO PARA ACTUALIZAR UN Historia
        public HistoriaClinica UpdateHistoria(HistoriaClinica historia)
        {
            var historiaEncontrada=_appContext.HistoriasClinicas.FirstOrDefault(c => c.Id==historia.Id);
            if(historiaEncontrada!=null)
            {
                historiaEncontrada.Mascota= historia.Mascota;
                historiaEncontrada.Peso= historia.Peso;
                historiaEncontrada.Temperatura= historia.Temperatura;
                historiaEncontrada.FrecuenciaRespiratoria= historia.FrecuenciaRespiratoria;
                historiaEncontrada.FrecuenciaCardiaca= historia.FrecuenciaCardiaca;
                historiaEncontrada.EstadoDeSalud= historia.EstadoDeSalud;
                historiaEncontrada.Visita= historia.Visita;

                _appContext.SaveChanges();
                
            }
            return historiaEncontrada;
        }
    }
}