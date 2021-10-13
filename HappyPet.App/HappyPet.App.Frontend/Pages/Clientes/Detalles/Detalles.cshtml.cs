using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Clientes.Detalles
{
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;

        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        public Cliente Cliente{get;set;}

        //METOD COSTRUCTOR
        public DetallesModel(IRepositorioCliente repositorioClientes)
        {
            this.repositorioClientes= repositorioClientes;
        }

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet(int idCliente)
        {
            Cliente= repositorioClientes.GetCliente(idCliente);
            if(Cliente != null){
                return Page();
                
            }else{
                return RedirectToPage("../../Error");
            }            
        }


    }
}