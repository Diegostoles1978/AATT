using System;
using System.Diagnostics;
namespace AcciTransito.App.Dominio.Entidades
{
    public class Vehiculos_Accidente
    {
    public int id{get;set;}
     public Accidentes id_Accidente {get;set;}
     public Vehiculos  id_vehiculo {get;set;}

    }
}