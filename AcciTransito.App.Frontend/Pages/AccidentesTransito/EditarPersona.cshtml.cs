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
        public class EditarPersonaModel : PageModel
    {
        private readonly IRepositorioPersonas repositoriopersonas;
        [BindProperty]
        public Personas personaje {get;set;}

        public EditarPersonaModel(IRepositorioPersonas repositoriopersonas)
        {
            this.repositoriopersonas=repositoriopersonas;

        }
         public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
            personaje= repositoriopersonas.GetPersonas(id.Value);
            }
            else
            {
                personaje = new Personas();
            }
            if (personaje==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }

          public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(personaje.id>0)
            {
                personaje = repositoriopersonas.UpdatePersonas(personaje);
            }
            else
            {
                repositoriopersonas.AddPersonas(personaje);
            }
            return Page();
        }
    }
}