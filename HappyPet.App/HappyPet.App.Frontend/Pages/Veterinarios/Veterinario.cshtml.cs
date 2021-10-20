using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HappyPet.App.Persistencia.AppRepositorios;
using HappyPet.App.Persistencia;
using HappyPet.App.Dominio;

namespace HappyPet.App.Frontend.Pages.Veterinarios
{
    public class VeterinarioModel : PageModel
    {
       //Se crea una referencia o atributo  TIPO IRepositorioSaludos de SOLO LECTURA (readOnly)
        private readonly IRepositorioVeterinario repositorioVeterinario;
        
        public IEnumerable<Veterinario> Veterinarios{get;set;}



        public VeterinarioModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario= repositorioVeterinario;
        }

        public void OnGet()
        {
            Veterinarios= repositorioVeterinario.GetAllVeterinarios();
        }
    }
}

