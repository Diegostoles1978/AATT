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

   public class ListaAccidentesModel : PageModel
    {

       private readonly IRepositorioAccidente repositorioaccidente;

       public   IEnumerable<Accidentes> accidentes {get;set;}


       public ListaAccidentesModel(IRepositorioAccidente repositorioaccidente )
       {
            this.repositorioaccidente=repositorioaccidente;

       }


        public void OnGet()
        {

          accidentes=repositorioaccidente.GetAllAccidente();


        }
    }
}
