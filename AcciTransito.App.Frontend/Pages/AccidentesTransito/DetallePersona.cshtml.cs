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
           private readonly IRepositorioPersonas repositoriopersonas;

           public Personas personas {get;set;}


        public DetallePersonaModel(IRepositorioPersonas repositoriopersonas)
        {
            this.repositoriopersonas=repositoriopersonas;
        }

        public IActionResult OnGet(int id)
        {
            personas= repositoriopersonas.GetPersonas(id);
            if (personas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }
    }
}




