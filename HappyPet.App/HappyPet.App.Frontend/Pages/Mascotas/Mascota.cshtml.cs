using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;
using HappyPet.App.Dominio;

namespace HappyPet.App.Frontend.Pages.Mascotas
{
    public class MascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        
        public IEnumerable<Mascota> Mascotas{get;set;}

        public MascotaModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota= repositorioMascota;
        }

        public void OnGet()
        {
            Mascotas= repositorioMascota.GetAllMascotas();
        }
    }
}
