using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;
using AcciTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcciTransito.App.Frontend.Pages
{
    public class DetallePersonaModel : PageModel
    {
           private readonly IRepositorioPersonas repositorioPersonas;

           public Personas personaje {get;set;}


        public DetallePersonaModel(IRepositorioPersonas repositorioPersonas)
        {
            this.repositorioPersonas=repositorioPersonas;
        }

        public IActionResult OnGet(int id)
        {
            personaje= repositorioPersonas.GetPersonas(id);
            if (personaje==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }
    }
}




