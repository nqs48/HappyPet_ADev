using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;
using HappyPet.App.Dominio;

namespace HappyPet.App.Frontend.Pages.Administrador.Historias
{
    public class HistoriaModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistoriaClinica;
        
        public IEnumerable<HistoriaClinica> HistoriaClinicas{get;set;}

        public HistoriaModel(IRepositorioHistoriaClinica repositorioHistoriaClinica)
        {
            this.repositorioHistoriaClinica= repositorioHistoriaClinica;
        }

        public void OnGet()
        {
            HistoriaClinicas= repositorioHistoriaClinica.GetAllHistorias();
        }
    }
}
