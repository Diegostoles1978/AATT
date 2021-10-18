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
        public class EditarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculos;
        [BindProperty]
        public Vehiculos vehiculos {get;set;}

        public EditarVehiculoModel(IRepositorioVehiculo repositorioVehiculos)
        {
            this.repositorioVehiculos=repositorioVehiculos;

        }
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
            vehiculos= repositorioVehiculos.GetVehiculos(id.Value);
            }
            else
            {
                vehiculos = new Vehiculos();
            }
            if (vehiculos==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }

        }
         public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(vehiculos.id>0)
            {
                vehiculos = repositorioVehiculos.UpdateVehiculos(vehiculos);
            }
            else
            {
                repositorioVehiculos.AddVehiculos(vehiculos);
            }
            return Page();
        }
    }
}