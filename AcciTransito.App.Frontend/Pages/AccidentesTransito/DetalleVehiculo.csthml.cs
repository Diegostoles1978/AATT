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
    public class DetalleVehiculoModel : PageModel
    {
           private readonly IRepositorioVehiculo repositorioVehiculos;

           public Vehiculos vehiculos {get;set;}


        public DetalleVehiculoModel(IRepositorioVehiculo repositorioVehiculos)
        {
            this.repositorioVehiculos=repositorioVehiculos;
        }

        public IActionResult OnGet(int id)
        {
            vehiculos= repositorioVehiculos.GetVehiculos(id);
            if (vehiculos==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }
    }
}

