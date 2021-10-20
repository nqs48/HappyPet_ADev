using System.Collections.Generic;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistorias();

        //Crear HistoriaClinica
        HistoriaClinica AddHistoria(HistoriaClinica historia);
        HistoriaClinica AsignarVisita(HistoriaClinica historia);

        //Actualizar HistoriaClinica
        HistoriaClinica UpdateHistoria(HistoriaClinica historiaActualizada);

        //Eliminar HistoriaClinica
        HistoriaClinica DeleteHistoria(int idHistoria);

        //Buscar HistoriaClinica
        HistoriaClinica GetHistoria(int idHistoria);  


    }
}