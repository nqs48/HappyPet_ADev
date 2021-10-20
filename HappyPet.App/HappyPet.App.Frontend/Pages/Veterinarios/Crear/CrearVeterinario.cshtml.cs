using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Veterinarios.Crear
{
    public class CrearVeterinarioModel : PageModel
    {
            private readonly IRepositorioVeterinario repositorioVeterinarios;
            
            
            //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
            [BindProperty]
            public Veterinario Veterinario{get;set;}
            //public Veterinario Veterinario2{get;set;}
            //public IEnumerable<Veterinario> Veterinarios{get;set;}

            //METOD COSTRUCTOR
            public CrearVeterinarioModel(IRepositorioVeterinario repositorioVeterinarios)
            {
                this.repositorioVeterinarios= repositorioVeterinarios;
            }

        

            //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
            public IActionResult OnGet()
            {   
                if(!ModelState.IsValid){
                return Page();
                }
                Veterinario = new Veterinario();
                if(Veterinario == null){
                    return RedirectToPage("../../Error");
                }else{
                    return Page();
                }
            }

            public IActionResult OnPost()
            {   
                    repositorioVeterinarios.AddVeterinario(Veterinario);
                    return RedirectToPage("../Veterinario");
           
            }
    }
}
