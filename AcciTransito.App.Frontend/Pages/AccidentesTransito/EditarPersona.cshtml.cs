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
        private readonly IRepositorioPersonas repositorioPersonas;
        [BindProperty]
        public Personas personas {get;set;}

        public EditarPersonaModel(IRepositorioPersonas repositorioPersonas)
        {
            this.repositorioPersonas=repositorioPersonas;

        }
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
            personas= repositorioPersonas.GetPersonas(id.Value);
            }
            else
            {
                personas = new Personas();
            }
            if (personas==null)
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
            if(personas.id>0)
            {
                personas = repositorioPersonas.UpdatePersonas(personas);
            }
            else
            {
                repositorioPersonas.AddPersonas(personas);
            }
            return Page();
        }
    }
}