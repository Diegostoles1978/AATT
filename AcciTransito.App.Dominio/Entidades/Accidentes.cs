using System;
using System.Diagnostics;

namespace AcciTransito.App.Dominio.Entidades
{
      public class Accidentes
    {
     public int id {get;set;}
     public String NumeroAccidente {get;set;}
     public DateTime Fecha {get;set;}
     public String Peritaje  {get;set;}
     public Coordenadas IdCoordenadas  {get;set;}
     public AgenteTransito AgenteTransito  {get;set;}

    }

}
