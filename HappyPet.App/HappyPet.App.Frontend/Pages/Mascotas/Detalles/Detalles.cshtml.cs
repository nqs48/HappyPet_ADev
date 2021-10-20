using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Mascotas.Detalles
{
    public class DetallesModel : PageModel
    {
      private readonly IRepositorioMascota repositorioMascotas;

        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        public Mascota Mascota{get;set;}

        //METOD COSTRUCTOR
        public DetallesModel(IRepositorioMascota repositorioMascotas)
        {
            this.repositorioMascotas= repositorioMascotas;
        }

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idMascota)
        {
            Mascota= repositorioMascotas.GetMascota(idMascota);
            if(Mascota != null){
                return Page();
                
            }else{
                return RedirectToPage("../../Error");
            }            
        }
    }
}
