
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class RepositorioAccidentes : IRepositorioAccidente
        { ///<summary>
        ///Referencia al contexto de accidentes
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioAccidentes(AppContext appContext) => _appContext = appContext;
        public Accidentes AddAccidente(Accidentes accidente) {
            var accidenteAdicionar=_appContext.Accidentes.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionar.Entity;

        }

        void IRepositorioAccidente.DeleteAccidente(int id) {
            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(p => p.id==id);
            if(accidenteEncontrado==null)
            return;
            _appContext.Accidentes.Remove(accidenteEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Accidentes> GetAllAccidente() {
          return _appContext.Accidentes;
        }

        public Accidentes GetAccidente(int id) {
          return _appContext.Accidentes.FirstOrDefault (p => p.id==id);
        }

        public Accidentes UpdateAccidente(Accidentes accidente) {
            var accidenteEncontrado= _appContext.Accidentes.FirstOrDefault(p => p.id==accidente.id);
            if (accidenteEncontrado!=null)
            {
                accidenteEncontrado.NumeroAccidente=accidente.NumeroAccidente;
                accidenteEncontrado.Fecha=accidente.Fecha;
                accidenteEncontrado.Peritaje=accidente.Peritaje;
                accidenteEncontrado.IdCoordenadas=accidente.IdCoordenadas;


                _appContext.SaveChanges();

            }

             return accidenteEncontrado;
        }

    }
}
