using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioAccidentePersonas {
        Accidentes AddAccidentePersona(Accidentes accidente);
        void DeleteAccidentePersona(int id);
        Accidentes GetAccidentePersona(int id);
        IEnumerable<Accidentes> GetAllAccidentePersona();
        Accidentes UpdateAccidentePersona(Accidentes accidente);
    }


}