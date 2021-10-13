using System.Collections.Generic;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();

        //Crear Mascota
        Mascota AddMascota(Mascota mascota);

        //Actualizar Mascota
        Mascota UpdateMascota(Mascota mascotaActualizada);

        //Eliminar Mascota
        Mascota DeleteMascota(int idMascota);

        //Buscar Mascota
        Mascota GetMascota(int idMascota);
    }
}