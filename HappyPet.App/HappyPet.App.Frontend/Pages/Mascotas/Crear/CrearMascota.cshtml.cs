using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Mascotas.Crear
{
    public class CrearMascotaModel : PageModel
    {
      private readonly IRepositorioMascota repositorioMascotas;
      private readonly IRepositorioCliente repositorioCliente;
             
      //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
      
     [BindProperty] 
      public Mascota mascota{get;set;}

      [BindProperty]
      public int clienteSeleccionado{get;set;}
      
      //public IEnumerable<Mascota> Mascotas{get;set;}
      public IEnumerable<Cliente> Clientes{get;set;}


      //METOD COSTRUCTOR
      public CrearMascotaModel(IRepositorioMascota repositorioMascotas, IRepositorioCliente repositorioCliente)
        {
          this.repositorioMascotas= repositorioMascotas;
          this.repositorioCliente= repositorioCliente;

        }

        

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet()
        { 
          Clientes= repositorioCliente.GetAllClientes();

          if(!ModelState.IsValid){
            return Page();
          }
          mascota = new Mascota();
          if(mascota == null){
            return RedirectToPage("../../Error");
          }else{
           return Page();
          }
        }

        public IActionResult OnPost()
        {   
          mascota = repositorioMascotas.AddMascota(mascota);
          if(clienteSeleccionado != -1 ){
            Cliente cliente= repositorioCliente.GetCliente(clienteSeleccionado);
            mascota.Cliente= cliente;
            repositorioMascotas.AsignarCliente(mascota); 
          }
          return RedirectToPage("../Mascota");
           
        }
    }
}
