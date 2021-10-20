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
    public class PersonasGeneroModel : PageModel
    {

       private readonly IRepositorioPersonas repositoriopersona;
       public   IEnumerable<Personas> generos {get;set;}

       public PersonasGeneroModel(IRepositorioPersonas repositoriopersona)
       {
            this.repositoriopersona=repositoriopersona;
       }

        public void OnGet()
        {

          generos=repositoriopersona.GetPersonasGenero();
          generos.Count();



        }
    }
}