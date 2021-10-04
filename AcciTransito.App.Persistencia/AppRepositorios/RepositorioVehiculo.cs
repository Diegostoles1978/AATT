
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
        public Vehiculo AddVehiculo(Vehiculo vehiculo) {
            var vehiculoAdicionar=_appContext.Vehiculo.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionar.Entity;

        }

        void IRepositorioVehiculo.DeleteVehiculo(int id) {
            var vehiculoEncontrada=_appContext.Vehiculo.FirstOrDefault(p => p.id==id);
            if(vehiculoEncontrada==null)
            return;
            _appContext.Vehiculo.Remove(vehiculoEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<Vehiculo> GetAllVehiculo() {
          return _appContext.Vehiculo;
        }

        public Vehiculo GetVehiculo(int id) {
          return _appContext.Vehiculo.FirstOrDefault (p => p.id==id);
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo) {
            var vehiculoEncontrada= _appContext.Vehiculo.FirstOrDefault(p => p.id==vehiculo.id);
            if (vehiculoEncontrada!=null)
            {
                vehiculoEncontrada.Placa=vehiculo.Placa;
                vehiculoEncontrada.Marca=vehiculo.Marca;
                vehiculoEncontrada.Modelo=vehiculo.Modelo;
                vehiculoEncontrada.TipoVehiculo=vehiculo.TipoVehiculo;
                vehiculoEncontrada.LicenciaTransito=vehiculo.LicenciaTransito;


                _appContext.SaveChanges();

            }

             return vehiculoEncontrada;
        }

    }
}
