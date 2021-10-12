using System;
using System.Diagnostics;

namespace AcciTransito.App.Dominio.Entidades
{

      public class Personas
    {
     public int  id  {get;set;}
     public String Nombres  {get;set;}
     public String Apellidos  {get;set;}
     //enum
     public TipoDocumento  TipoDocumento  {get;set;}
     public String NumeroIdentificacion  {get;set;}
     public DateTime FechaNacimiento {get;set;}
     public String Direccion  {get;set;}
     public String Ciudad  {get;set;}
     public long NumeroCelular {get;set;}
     public long ContactoAlterno  {get;set;}
     public String  CorreoElectronico {get;set;}
     //clase
     public Genero  Genero {get;set;}

    }
 }
