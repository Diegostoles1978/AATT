using System;
using System.Diagnostics;

namespace AcciTransito.App.Dominio.Entidades
{
     
      public class Vehiculo
    {
     
     public int  id  {get;set;}
     public String Placa  {get;set;}
     public String Marca  {get;set;}
     public String Modelo  {get;set;}
     public String TipoVehiculo  {get;set;}
    public String LicenciaTransito {get;set;}
    public Personas Persona{get;set;}
    }     
 }