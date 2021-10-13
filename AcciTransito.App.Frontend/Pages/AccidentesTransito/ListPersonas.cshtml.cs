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
    public class ListModel1 : PageModel
    {

       private readonly IRepositorioPersonas repositorioPersonas;
       public   IEnumerable<Personas> personas {get;set;}

       public ListModel1(IRepositorioPersonas repositorioPersonas)
       {
            this.repositorioPersonas=repositorioPersonas;
       }

        public void OnGet()
        {

          personas=repositorioPersonas.GetAll();

        }
    }
}
