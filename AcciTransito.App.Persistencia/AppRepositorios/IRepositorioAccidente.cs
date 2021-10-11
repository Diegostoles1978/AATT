using System.Collections.Generic;
using System;
using System.Diagnostics;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
<<<<<<< HEAD
    public interface IRepositorioAccidente
    {
    IEnumerable<Accidente> GetAllAccidente();
    Personas AddAccidente(Accidente accidente);
    Personas UpdateAccidente(Accidente accidente);
    void DeleteAccidente(int id);

        Personas GetAccidente(int id);
        //Cristian Estuvo aqui
    }
=======
    public interface IRepositorioAccidente {
        Accidentes AddAccidente(Accidentes accidente);
        void DeleteAccidente(int id);
        Accidentes GetAccidente(int id);
        IEnumerable<Accidentes> GetAllAccidente();
        Accidentes UpdateAccidente(Accidentes accidente);
    }


>>>>>>> fc3f27482b23f672ce983abbb2f71bb23a5c4834
}