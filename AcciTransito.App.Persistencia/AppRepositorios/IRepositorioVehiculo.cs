
using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;


namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioVehiculo
    {

       IEnumerable<Vehiculos> GetAllVehiculos();
       Vehiculos AddVehiculos(Vehiculos vehiculo);
       Vehiculos UpdateVehiculos(Vehiculos vehiculo);
       void DeleteVehiculos(int id);

        Vehiculos GetVehiculos(int id);
    }




}