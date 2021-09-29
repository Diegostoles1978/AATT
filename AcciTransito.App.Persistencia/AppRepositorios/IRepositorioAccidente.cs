using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAccidente
    {
       IEnumerable<Accidente> GetAllAccidente();
       Personas AddAccidente(Accidente accidente);
       Personas UpdateAccidente(Accidente accidente);
       void DeleteAccidente(int id);

        Personas GetAccidente(int id);

    }
}