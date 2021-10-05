using System;
using System.Diagnostics;
namespace AcciTransito.App.Dominio.Entidades
{
    public class Vehiculo_Accidente
    {
    public int id{get;set;}
     public Accidente id_Accidente {get;set;}
     public Vehiculo  id_vehiculo {get;set;}

    }
}