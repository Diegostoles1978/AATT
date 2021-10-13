using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AcciTransito.App.Dominio.Entidades
{

      public class Personas

    {
     public int  id  {get;set;}

     [Required(ErrorMessage = "Campo Requerido")]
     [StringLength(6, MinimumLength = 8, ErrorMessage="El documento debe tener min 6 digitos max 8")]
      public String NumeroIdentificacion  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Nombres  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Apellidos  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public DateTime FechaNacimiento {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Direccion  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Ciudad  {get;set;}
     public int NumeroCelular {get;set;}

      [Required(ErrorMessage = "Campo Requerido")]
      public int ContactoAlterno  {get;set;}
      [Required(ErrorMessage = "Campo Requerido")]
      [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "El formato de correo no es válido")]
      public String  CorreoElectronico {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public Genero  Genero {get;set;}

    }
 }
