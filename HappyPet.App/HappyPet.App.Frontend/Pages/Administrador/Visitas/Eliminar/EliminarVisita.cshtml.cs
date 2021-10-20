using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Visitas.Eliminar
{
    public class EliminarVisitaModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisitas;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Visita Visita{get;set;}

        //METOD COSTRUCTOR
        public EliminarVisitaModel(IRepositorioVisita repositorioVisitas)
        {
            this.repositorioVisitas= repositorioVisitas;
        }


        public IActionResult OnGet(int idVisita)
        {
            Visita=repositorioVisitas.DeleteVisita(idVisita);
            return Page();
            
        }
    }
}
