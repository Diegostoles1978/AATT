
using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;


namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioPersonas
    {

         IEnumerable<Personas> GetAllPersonas();
       Personas AddPersonas(Personas personas);
       Personas UpdatePersonas(Personas personas);
      void DeletePersonas(int id);

       Personas GetPersonas(int idpersona);


    }




}