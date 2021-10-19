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

   public class ListModel5 : PageModel
    {

       private readonly IRepositorioAccidente repositorioaccidente;
       private readonly IRepositorioPersonas repositoriopersonas;
       public   IEnumerable<Accidentes> accidentes {get;set;}
       public   IEnumerable<Personas> per {get;set;}

       public ListModel5(IRepositorioAccidente repositorioaccidente, IRepositorioPersonas repositoriopersonas)
       {
            this.repositorioaccidente=repositorioaccidente;
             this.repositoriopersonas=repositoriopersonas;
       }



        public void OnGet()
        {

          accidentes=repositorioaccidente.GetAllAccidente();
          per=repositoriopersonas.GetAllPersona();

        }
    }
}
