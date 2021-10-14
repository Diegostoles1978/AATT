using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AcciTransito.App.Dominio.Entidades
{

      public class Personas

    {
     public int  id  {get;set;}
     public String Nombres  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Apellidos  {get;set;}
     //enum
     public TipoDocumento  TipoDocumento  {get;set;}
     public String NumeroIdentificacion  {get;set;}
     public DateTime FechaNacimiento {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Direccion  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Ciudad  {get;set;}
     public long NumeroCelular {get;set;}
     public long ContactoAlterno  {get;set;}
     public String  CorreoElectronico {get;set;}
     //clase
     public Genero  Genero {get;set;}

    }
 }
