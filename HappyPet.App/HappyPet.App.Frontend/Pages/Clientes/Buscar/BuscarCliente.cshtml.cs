using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Clientes.Buscar
{
    public class BuscarClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Cliente Cliente{get;set;}

        // [BindProperty]
        // public int clienteSeleccionado{get;set;}

        public IEnumerable<Cliente> Clientes{get;set;}



        //METOD COSTRUCTOR
        public BuscarClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente= repositorioCliente;
        }

     

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public void OnGet()
            {
              Clientes= repositorioCliente.GetAllClientes();

              //Cliente= repositorioCliente.GetCliente(clienteSeleccionado);

              Page();
              //Cliente = repositorioCliente.GetCliente(clienteSeleccionado);
              
            } 

        //  public IActionResult OnPost()
        //     {   
        //         Cliente= repositorioCliente.GetCliente(clienteSeleccionado);
        //         return  RedirectToPage("../Detalles/Detalle");
                
        // //         Cliente = repositorioCliente.GetCliente(clienteSeleccionado);

        // //         Console.WriteLine("ID de Busqueda: "+clienteSeleccionado);
        // //         if(Cliente == null){
        // //           return RedirectToPage("../../Error");
        // //         }else
        // //         {
        // //             return RedirectToPage("../Detalles/Detalles");
        // //         }
                
           
        //    }             
    }
}

