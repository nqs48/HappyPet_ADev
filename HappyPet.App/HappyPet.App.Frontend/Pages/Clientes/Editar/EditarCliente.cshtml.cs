using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Clientes.Editar
{
    public class EditarClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Cliente Cliente{get;set;}

        //METOD COSTRUCTOR
        public EditarClienteModel(IRepositorioCliente repositorioClientes)
        {
            this.repositorioClientes= repositorioClientes;
        }

     

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idCliente)
        {
                Cliente= repositorioClientes.GetCliente(idCliente);
                if(Cliente == null){
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
            if(Cliente.Id > 0){
                Cliente= repositorioClientes.UpdateCliente(Cliente);
                return Page();
            }
            else
            {
                return RedirectToPage("../../Error");
            } 
            
        }
    }
}
