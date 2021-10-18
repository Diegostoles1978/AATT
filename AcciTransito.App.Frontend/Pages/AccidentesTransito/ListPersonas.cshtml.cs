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
    public class ListModel : PageModel
    {

       private readonly IRepositorioPersonas repositoriopersonas;
       public   IEnumerable<Personas> personas {get;set;}

       public ListModel(IRepositorioPersonas repositoriopersonas)
       {
            this.repositoriopersonas=repositoriopersonas;
       }

        public void OnGet()
        {

          personas=repositoriopersonas.GetAllPersonas();

        }
    }
}
