
using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;


namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioVehiculo
    {

       IEnumerable<Vehiculo> GetAllVehiculo();
       Vehiculo AddVehiculo(Vehiculo vehiculo);
       Vehiculo UpdateVehiculo(Vehiculo vehiculo);
       void DeleteVehiculo(int id);

        Vehiculo GetVehiculo(int id);
    }




}