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
        public class EditarAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioaccidente;
        [BindProperty]
        public Accidentes accidentes {get;set;}

        public EditarAccidenteModel(IRepositorioAccidente repositorioaccidente)
        {
            this.repositorioaccidente=repositorioaccidente;

        }
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
            accidentes= repositorioaccidente.GetAccidente(id.Value);
            }
            else
            {
                accidentes = new Accidentes();
            }
            if (accidentes==null)
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
            if(accidentes.id>0)
            {
                accidentes = repositorioaccidente.UpdateAccidente(accidentes);
            }
            else
            {
                repositorioaccidente.AddAccidente(accidentes);
            }
            return Page();
        }
    }
}