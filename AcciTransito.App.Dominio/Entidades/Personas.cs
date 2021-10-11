using System;
using System.Diagnostics;

namespace AcciTransito.App.Dominio.Entidades
{

      public class Personas
    {
     public int  id  {get;set;}
     public String NumeroIdentificacion  {get;set;}
     public String Nombre  {get;set;}
     public String Apellidos  {get;set;}
     public DateTime FechaNacimiento {get;set;}
     public String Direccion  {get;set;}
     public int NumeroCelular {get;set;}
     public String  CorreoElectronico {get;set;}
     public Genero  Genero {get;set;}

    }
 }
