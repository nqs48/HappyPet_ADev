using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Clientes.Crear
{
    public class CrearClienteModel : PageModel
    {
        
            private readonly IRepositorioCliente repositorioClientes;
            
            
            //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
            [BindProperty]
            public Cliente Cliente{get;set;}
            public Cliente Cliente2{get;set;}
            public IEnumerable<Cliente> Clientes{get;set;}

            //METOD COSTRUCTOR
            public CrearClienteModel(IRepositorioCliente repositorioClientes)
            {
                this.repositorioClientes= repositorioClientes;
            }

        

            //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
            public IActionResult OnGet()
            {   
                  // Clientes= repositorioClientes.GetAllClientes();
                Cliente = new Cliente();
                if(Cliente == null){
                    return RedirectToPage("../../Error");
                }else{
                    return Page();
                }
            }

            public IActionResult OnPost()
            {   
                    repositorioClientes.AddCliente(Cliente);
                    return Page();
           
            }
    
    
}
}
