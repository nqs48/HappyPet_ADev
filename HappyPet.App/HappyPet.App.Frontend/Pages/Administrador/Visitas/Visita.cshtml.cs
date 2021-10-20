using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;
using HappyPet.App.Dominio;

namespace HappyPet.App.Frontend.Pages.Administrador.Visitas
{
    public class VisitaModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        
        public IEnumerable<Visita> Visitas{get;set;}

        public VisitaModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita= repositorioVisita;
        }

        public void OnGet()
        {
            Visitas= repositorioVisita.GetAllVisitas();
        }
    }
}
