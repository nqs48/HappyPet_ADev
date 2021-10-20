using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Visitas.Crear
{
    public class CrearVisitaModel : PageModel
    {

      private readonly IRepositorioVisita repositorioVisitas;
      private readonly IRepositorioMascota repositorioMascotas;
      private readonly IRepositorioVeterinario repositorioVeterinario;
             
      //Se crea un atributo tipo Saludo donde se almacenaran los datos del IRepositorio
      
     [BindProperty] 
      public Visita visita{get;set;}

      [BindProperty]
      public int MascotaSeleccionada{get;set;}

      [BindProperty]
      public int VeterinarioSeleccionado{get;set;}

      
      //public IEnumerable<Mascota> Mascotas{get;set;}
      public IEnumerable<Mascota> Mascotas{get;set;}
      public IEnumerable<Veterinario> Veterinarios{get;set;}


//CONSTRUCTOR DE CLASE VISITA
        public CrearVisitaModel(IRepositorioVisita repositorioVisitas, IRepositorioMascota repositorioMascotas, IRepositorioVeterinario repositorioVeterinario)
        {
          this.repositorioVisitas= repositorioVisitas;
          this.repositorioMascotas= repositorioMascotas;
          this.repositorioVeterinario= repositorioVeterinario;

        }

        //METODO QUE DEVUELVE UN RESULTADO TIPO PAGINA
        public IActionResult OnGet()
        { 
          Mascotas= repositorioMascotas.GetAllMascotas();
          Veterinarios= repositorioVeterinario.GetAllVeterinarios();

          if(!ModelState.IsValid){
            return Page();
          }
          visita = new Visita();
          if(visita == null){
            return RedirectToPage("../../Error");
          }else{
           return Page();
          }
        }

        public IActionResult OnPost()
        {   
          visita = repositorioVisitas.AddVisita(visita);
          
          if(VeterinarioSeleccionado != -1 ){
            Veterinario Veterinario= repositorioVeterinario.GetVeterinario(VeterinarioSeleccionado);
            Mascota Mascota= repositorioMascotas.GetMascota(MascotaSeleccionada);

            visita.Veterinario= Veterinario;
            visita.Mascota=Mascota;
            repositorioVisitas.AsignarVeterinario(visita);
            repositorioVisitas.AsignarMascota(visita); 
          }
          return RedirectToPage("../Visita");
           
        }
    }
}
