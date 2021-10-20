using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages.Administrador.Historias.Crear
{
    public class CrearHistoriaModel : PageModel
    {
        public void OnGet()
      {

      }





      //   private readonly IRepositorioHistoriaClinica repositorioHistorias;
      //   private readonly IRepositorioMascota repositorioMascotas;
      //   private readonly IRepositorioVisita repositorioVisitas;


      //   [BindProperty] 
      //   public HistoriaClinica Historia{get;set;}

      //   [BindProperty]
      //   public int MascotaSeleccionada{get;set;}

      //   [BindProperty]
      //   public int VisitaSeleccionada{get;set;}



      //   public IEnumerable<Mascota> Mascotas{get;set;}
      //   public IEnumerable<Visita> Visitas{get;set;}



      //   public CrearHistoriaModel(IRepositorioVisita repositorioVisitas, IRepositorioMascota repositorioMascotas, IRepositorioHistoriaClinica repositorioHistorias)
      //   {
      //     this.repositorioVisitas= repositorioVisitas;
      //     this.repositorioMascotas= repositorioMascotas;
      //     this.repositorioHistorias= repositorioHistorias;

      //   }
      //  public IActionResult OnGet()
      //   { 
      //     Mascotas= repositorioMascotas.GetAllMascotas();
      //     Visitas= repositorioVisitas.GetAllVisitas();

      //     if(!ModelState.IsValid){
      //       return Page();
      //     }
      //     Historia = new HistoriaClinica();
      //     if(Historia == null){
      //       return RedirectToPage("../../Error");
      //     }else{
      //      return Page();
      //     }
      //   }

      //   public IActionResult OnPost()
      //   {   
      //     Historias = repositorioVisitas.AddVisita(visita);
          
      //     if(VeterinarioSeleccionado != -1 ){
      //       Veterinario Veterinario= repositorioVeterinario.GetVeterinario(VeterinarioSeleccionado);
      //       Mascota Mascota= repositorioMascotas.GetMascota(MascotaSeleccionada);

      //       visita.Veterinario= Veterinario;
      //       visita.Mascota=Mascota;
      //       repositorioVisitas.AsignarVeterinario(visita);
      //       repositorioVisitas.AsignarMascota(visita); 
      //     }
      //     return RedirectToPage("../Visita");
           
      //   }

    }
}
