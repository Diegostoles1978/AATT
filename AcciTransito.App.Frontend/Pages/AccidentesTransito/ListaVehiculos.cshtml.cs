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
    public class ListaVehiculoModel: PageModel
    {private readonly IRepositorioVehiculo repositoriovehiculos;
       public   IEnumerable<Vehiculos> vehiculo {get;set;}

       public ListaVehiculoModel(IRepositorioVehiculo repositoriovehiculos)
       {
            this.repositoriovehiculos=repositoriovehiculos;
       }

        public void OnGet()
        {

          vehiculo=repositoriovehiculos.GetAllVehiculos();

        }

           }
}
