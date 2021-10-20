using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Veterinarios.Editar
{
    public class EditarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Veterinario Veterinario{get;set;}

        //METOD COSTRUCTOR
        public EditarVeterinarioModel(IRepositorioVeterinario repositorioVeterinarios)
        {
            this.repositorioVeterinarios= repositorioVeterinarios;
        }

     

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idVeterinario)
        {
                Veterinario= repositorioVeterinarios.GetVeterinario(idVeterinario);
                if(Veterinario == null){
                    return RedirectToPage("../../Error");
                }else{
                    return Page();
                }            
             
        }

        public IActionResult OnPost()
        {   
            if(!ModelState.IsValid){
                return Page();
            }
            if(Veterinario.Id > 0){
                Veterinario= repositorioVeterinarios.UpdateVeterinario(Veterinario);
                return Page();
            }
            else
            {
                return RedirectToPage("../../Error");
            } 
            
        }
    }
}
