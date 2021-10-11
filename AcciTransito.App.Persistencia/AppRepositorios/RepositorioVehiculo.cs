
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo {
        ///<summary>
        ///Referencia al contexto de personas
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Vehiculos AddVehiculos(Vehiculos vehiculo) {
            var vehiculoAdicionar=_appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionar.Entity;

        }

        void IRepositorioVehiculo.DeleteVehiculos(int id) {
            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(p => p.id==id);
            if(vehiculoEncontrado==null)
            return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Vehiculos> GetAllVehiculos() {
          return _appContext.Vehiculos;
        }

        public Vehiculos GetVehiculos(int id) {
          return _appContext.Vehiculos.FirstOrDefault (p => p.id==id);
        }

        public Vehiculos UpdateVehiculos(Vehiculos vehiculo) {
            var vehiculoEncontrado= _appContext.Vehiculos.FirstOrDefault(p => p.id==vehiculo.id);
            if (vehiculoEncontrado!=null)
            {
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.Marca=vehiculo.Marca;
                vehiculoEncontrado.Modelo=vehiculo.Modelo;
                vehiculoEncontrado.TipoVehiculo=vehiculo.TipoVehiculo;
                vehiculoEncontrado.LicenciaTransito=vehiculo.LicenciaTransito;


                _appContext.SaveChanges();

            }

             return vehiculoEncontrado;
        }

    }
}
