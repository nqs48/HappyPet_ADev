using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;


namespace HappyPet.App.Frontend.Pages.Mascotas.Eliminar
{
    public class EliminarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Mascota Mascota{get;set;}

        //METOD COSTRUCTOR
        public EliminarMascotaModel(IRepositorioMascota repositorioMascotas)
        {
            this.repositorioMascotas= repositorioMascotas;
        }


        public IActionResult OnGet(int idMascota)
        {
            Mascota=repositorioMascotas.DeleteMascota(idMascota);
            return Page();
            
        }
    }
}
