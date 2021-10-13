using System.Collections.Generic;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisitas();

        //Crear Visita
        Visita AddVisita(Visita visita);

        //Actualizar Visita
        Visita UpdateVisita(Visita visitaActualizado);

        //Eliminar Visita
        Visita DeleteVisita(int idVisita);

        //Buscar Visita
        Visita GetVisita(int idVisita);
    }
}