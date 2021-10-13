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

       private readonly IRepositorioAccidente repositorioaccidente;
       public   IEnumerable<Accidentes> accidentes {get;set;}

       public ListModel(RepositorioAccidentes repositorioaccidente)
       {
            this.repositorioaccidente=repositorioaccidente;
       }



        public void OnGet()
        {

          accidentes=repositorioaccidente.GetAllAccidente();

        }
    }
}