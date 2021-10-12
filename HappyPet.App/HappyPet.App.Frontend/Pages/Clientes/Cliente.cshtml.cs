using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;
using HappyPet.App.Dominio;


namespace HappyPet.App.Frontend.Pages.Clientes
{
    public class ClienteModel : PageModel
    {
//Se crea una referencia o atributo  TIPO IRepositorioSaludos de SOLO LECTURA (readOnly)
        private readonly IRepositorioCliente repositorioCliente;
        
        public IEnumerable<Cliente> Clientes{get;set;}

        public ClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente= repositorioCliente;
        }

        public void OnGet()
        {
            Clientes= repositorioCliente.GetAllClientes();
        }
    }
}
