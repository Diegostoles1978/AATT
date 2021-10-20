using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;
namespace AcciTransito.App.Persistencia
{
   public interface IRepositorioPersonas
    {
       IEnumerable<Personas> GetAllPersona();
       Personas AddPersonas(Personas persona);
      void DeletePersonas(int id);

       Personas GetPersonas(int id);

        Personas UpdatePersonas(Personas persona);

        IEnumerable<Personas> GetPersonasGenero();

    }




}