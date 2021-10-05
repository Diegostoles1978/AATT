using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioAccidente {
        Accidente AddAccidente(Accidente accidente);
        void DeleteAccidente(int id);
        Accidente GetAccidente(int id);
        IEnumerable<Accidente> GetAllAccidente();
        Accidente UpdateAccidente(Accidente accidente);
    }


}