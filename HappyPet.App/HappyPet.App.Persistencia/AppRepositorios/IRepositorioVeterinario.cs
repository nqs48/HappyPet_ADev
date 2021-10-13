using System.Collections.Generic;
using HappyPet.App.Dominio;

namespace HappyPet.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
         IEnumerable<Veterinario> GetAllVeterinarios();

        //Crear Veterinario
        Veterinario AddVeterinario(Veterinario veterinario);

        //Actualizar Veterinario
        Veterinario UpdateVeterinario(Veterinario veterinarioActualizado);

        //Eliminar Veterinario
        Veterinario DeleteVeterinario(int idVeterinario);

        //Buscar Veterinario
        Veterinario GetVeterinario(int idVeterinario);
    }
}