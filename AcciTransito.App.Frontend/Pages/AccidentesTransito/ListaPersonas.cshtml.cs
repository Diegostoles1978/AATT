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
    public class ListaPersonasModel : PageModel
    {

       private readonly IRepositorioPersonas repositoriopersona;
       public   IEnumerable<Personas> personas {get;set;}

       public ListaPersonasModel(IRepositorioPersonas repositoriopersona)
       {
            this.repositoriopersona=repositoriopersona;
       }

        public void OnGet()
        {

          personas=repositoriopersona.GetAllPersona();

        }
    }
}
