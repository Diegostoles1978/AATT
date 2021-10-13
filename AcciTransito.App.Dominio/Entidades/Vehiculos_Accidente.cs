using System;
using System.Diagnostics;
namespace AcciTransito.App.Dominio.Entidades
{
    public class Vehiculos_Accidente
    {
    public int id{get;set;}
     public Accidentes Accidente {get;set;}
     public Vehiculos  Vehiculo {get;set;}

    }
}