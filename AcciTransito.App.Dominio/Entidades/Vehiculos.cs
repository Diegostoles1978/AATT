using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AcciTransito.App.Dominio.Entidades
{

      public class Vehiculos
    {

     public int  id  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Placa  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     [StringLength(6, MinimumLength = 4, ErrorMessage="La placa debe tener min 5 digitos max 6")]
     public String Marca  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String Modelo  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
     public String TipoVehiculo  {get;set;}
     [Required(ErrorMessage = "Campo Requerido")]
    public String LicenciaTransito {get;set;}

    public Personas Persona{get;set;}
    }
 }