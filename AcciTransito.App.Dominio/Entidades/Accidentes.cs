using System;
using System.Diagnostics;

namespace AcciTransito.App.Dominio.Entidades
{
      public class Accidentes
    {
     public int id {get;set;}
     public String NumeroAccidente {get;set;}
     public DateTime Fecha {get;set;}
     //enum
     public TipoAccidente TipoAccidente{get;set;}
     public String Peritaje  {get;set;}
     public String Direccion {get;set;}
     public Coordenadas Coordenadas  {get;set;}
     public String Barrio {get;set;}
     public AgenteTransito AgenteTransito  {get;set;}

    }

}
