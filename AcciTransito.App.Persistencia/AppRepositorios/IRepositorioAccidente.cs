using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioAccidente {
        Accidentes AddAccidente(Accidentes accidente);
        void DeleteAccidente(int id);
        Accidentes GetAccidente(int id);
        IEnumerable<Accidentes> GetAllAccidente();
        Accidentes UpdateAccidente(Accidentes accidente);
    }


}