using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      private readonly IRepositorioPersonas repositoriopersona;
        [BindProperty]
        public Personas personas1 {get;set;}

         public EditarPersonaModel(IRepositorioPersonas repositoriopersona) {
            this.repositoriopersona = repositoriopersona;
        }

         public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
               personas1=repositoriopersona.GetPersonas(id.Value);
            }
            else
            {
            personas1=new Personas();
            }
            if (personas1==null)
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
             if (personas1.id> 0) {
                  personas1 = repositoriopersona.UpdatePersonas(personas1);
           }
             else {

                 repositoriopersona.AddPersonas(personas1);
            }
            return Page();
         }
    }
}

