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
    public class DetalleAccidenteModel : PageModel
    {
           private readonly IRepositorioAccidente repositorioaccidente;

           public Accidentes accidentes {get;set;}


        public DetalleAccidenteModel(IRepositorioAccidente repositorioaccidente)
        {
            this.repositorioaccidente=repositorioaccidente;
        }

        public IActionResult OnGet(int id)
        {
            accidentes= repositorioaccidente.GetAccidente(id);
            if (accidentes==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }
    }
}




