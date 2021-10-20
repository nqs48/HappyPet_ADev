using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using HappyPet.App.Dominio;
using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;

namespace HappyPet.App.Frontend.Pages
{
    public class IndexModel : PageModel
    {

      private readonly IRepositorioVisita repositorioVisitas;
      private readonly IRepositorioMascota repositorioMascotas;
      private readonly IRepositorioVeterinario repositorioVeterinario;
      private readonly IRepositorioCliente repositorioCliente;
      private readonly IRepositorioHistoriaClinica repositorioHistoriaClinica;


      private readonly ILogger<IndexModel> _logger;


      public IEnumerable<Mascota> Mascotas{get;set;}
      public IEnumerable<Veterinario> Veterinarios{get;set;}
      public IEnumerable<Visita> Visitas{get;set;}
      public IEnumerable<Cliente> Clientes{get;set;}
      public IEnumerable<HistoriaClinica> Historias{get;set;}


        public IndexModel(ILogger<IndexModel> logger,IRepositorioVisita repositorioVisitas, IRepositorioMascota repositorioMascotas, IRepositorioVeterinario repositorioVeterinario,IRepositorioCliente repositorioCliente,IRepositorioHistoriaClinica repositorioHistoriaClinica)
        {
            _logger = logger;
            this.repositorioVisitas=repositorioVisitas;
            this.repositorioMascotas=repositorioMascotas;
            this.repositorioVeterinario=repositorioVeterinario;
            this.repositorioCliente=repositorioCliente;
            this.repositorioHistoriaClinica=repositorioHistoriaClinica;
        }

        public void OnGet()
        {
          
          Mascotas= repositorioMascotas.GetAllMascotas();
          Veterinarios= repositorioVeterinario.GetAllVeterinarios();
          Visitas=repositorioVisitas.GetAllVisitas();
          Clientes=repositorioCliente.GetAllClientes();
          Historias=repositorioHistoriaClinica.GetAllHistorias();

        }
    }
}
