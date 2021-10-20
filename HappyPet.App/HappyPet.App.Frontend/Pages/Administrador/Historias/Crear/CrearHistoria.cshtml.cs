using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Historias.Crear
{
    public class CrearHistoriaModel : PageModel
    {
      
        private readonly IRepositorioHistoriaClinica repositorioHistorias;
        private readonly IRepositorioVisita repositorioVisitas;


        [BindProperty] 
        public HistoriaClinica Historia{get;set;}

        [BindProperty]
        public int VisitaSeleccionada{get;set;}

      
        public IEnumerable<Visita> Visitas{get;set;}



        public CrearHistoriaModel(IRepositorioVisita repositorioVisitas, IRepositorioHistoriaClinica repositorioHistorias)
        {
          this.repositorioVisitas= repositorioVisitas;
          this.repositorioHistorias= repositorioHistorias;

        }

       public IActionResult OnGet()
        { 
          Visitas= repositorioVisitas.GetAllVisitas();

          if(!ModelState.IsValid){
            return Page();
          }
          Historia = new HistoriaClinica();
          if(Historia == null){
            return RedirectToPage("../../Error");
          }else{
           return Page();
          }
        }

        public IActionResult OnPost()
        {   
          Historia = repositorioHistorias.AddHistoria(Historia);
          
          if(VisitaSeleccionada != -1){

            Visita v1= repositorioVisitas.GetVisita(VisitaSeleccionada);
      
            Historia.Visita= v1;
           
            repositorioHistorias.AsignarVisita(Historia);
          }
          return RedirectToPage("../Historia");
           
        }

    }
}
