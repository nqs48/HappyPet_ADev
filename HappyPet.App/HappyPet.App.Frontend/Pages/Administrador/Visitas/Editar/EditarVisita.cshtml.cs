using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Visitas.Editar
{
    public class EditarVisitaModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisitas;
        private readonly IRepositorioVeterinario repositorioVeterinario;

        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Visita Visita{get;set;}

        [BindProperty]
        public int VeterinarioSeleccionado{get;set;}

        //LISTA DE VETERINARIOS
        public IEnumerable<Veterinario> Veterinarios{get;set;}

        //METOD COSTRUCTOR
        public EditarVisitaModel(IRepositorioVisita repositorioVisitas, IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVisitas= repositorioVisitas;
            this.repositorioVeterinario= repositorioVeterinario;
        }

     

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idVisita)
        {

                Visita= repositorioVisitas.GetVisita(idVisita);
                Veterinarios= repositorioVeterinario.GetAllVeterinarios();

                if(Visita == null){
                    return RedirectToPage("../../Error");
                }else{
                    return Page();
                }            
             
        }

        public IActionResult OnPost()
        {   

            Visita= repositorioVisitas.UpdateVisita(Visita);

            if(!ModelState.IsValid){
                return Page();
            }
            if(VeterinarioSeleccionado != -1){

                Veterinario Veterinario= repositorioVeterinario.GetVeterinario(VeterinarioSeleccionado);
                Visita.Veterinario= Veterinario;
                repositorioVisitas.AsignarVeterinario(Visita);
                return RedirectToPage("../Visita");
            }
            else
            {
                return RedirectToPage("../../Error");
            } 
            
        }
    }
}
