using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Visitas.Detalles
{
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisitas;

        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        public Visita Visita{get;set;}

        //METOD COSTRUCTOR
        public DetallesModel(IRepositorioVisita repositorioVisitas)
        {
            this.repositorioVisitas= repositorioVisitas;
        }

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idVisita)
        {
            Visita= repositorioVisitas.GetVisita(idVisita);
            if(Visita != null){
                return Page();
                
            }else{
                return RedirectToPage("../../Error");
            }            
        }
    }
}
