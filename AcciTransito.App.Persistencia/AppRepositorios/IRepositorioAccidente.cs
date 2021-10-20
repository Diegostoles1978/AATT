using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public interface IRepositorioAccidente {
        IEnumerable<Accidentes> GetAllAccidente();
        Accidentes AddAccidente(Accidentes accidente);
        void DeleteAccidente(int id);
        AgenteTransito AsignarAgente(int idaccidente, int idAgente);
        Accidentes GetAccidente(int id);


        Accidentes UpdateAccidente(Accidentes accidente);



    }


}