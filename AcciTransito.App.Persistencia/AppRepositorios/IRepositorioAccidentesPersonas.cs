using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioAccidentePersonas {
        Personas_Accidente AddAccidentePersona(Personas_Accidente accidente);
        void DeleteAccidentePersona(int id);
        Accidentes GetAccidentePersona(int id);
         Personas_Accidente GetAccidentePersona(int idpersona, int idaccidente);
        IEnumerable<Personas_Accidente> GetAllAccidentePersona();
        Personas_Accidente UpdateAccidentePersona(Personas_Accidente accidente);
    }


}