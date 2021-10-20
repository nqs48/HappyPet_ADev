using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Veterinarios.Eliminar
{
    public class EliminarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Veterinario Veterinario{get;set;}

        //METOD COSTRUCTOR
        public EliminarVeterinarioModel(IRepositorioVeterinario repositorioVeterinarios)
        {
            this.repositorioVeterinarios= repositorioVeterinarios;
        }


        public IActionResult OnGet(int idVeterinario)
        {
            Veterinario=repositorioVeterinarios.DeleteVeterinario(idVeterinario);
            return Page();
            
        }
    }
}
