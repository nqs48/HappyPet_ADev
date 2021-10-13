using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Clientes.Eliminar
{
    public class EliminarClienteModel : PageModel
    {

        private readonly IRepositorioCliente repositorioClientes;
        
        
        //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
        [BindProperty]
        public Cliente Cliente{get;set;}

        //METOD COSTRUCTOR
        public EliminarClienteModel(IRepositorioCliente repositorioClientes)
        {
            this.repositorioClientes= repositorioClientes;
        }


        public IActionResult OnGet(int idCliente)
        {
            Cliente=repositorioClientes.DeleteCliente(idCliente);
            return Page();
            
        }
    }
}
