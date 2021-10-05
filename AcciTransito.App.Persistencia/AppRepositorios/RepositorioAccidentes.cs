
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
        public Accidente AddAccidente(Accidente accidente) {
            var accidenteAdicionar=_appContext.Accidente.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionar.Entity;

        }

        void IRepositorioAccidente.DeleteAccidente(int id) {
            var accidenteEncontrado=_appContext.Accidente.FirstOrDefault(p => p.id==id);
            if(accidenteEncontrado==null)
            return;
            _appContext.Accidente.Remove(accidenteEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Accidente> GetAllAccidente() {
          return _appContext.Accidente;
        }

        public Accidente GetAccidente(int id) {
          return _appContext.Accidente.FirstOrDefault (p => p.id==id);
        }

        public Accidente UpdateAccidente(Accidente accidente) {
            var accidenteEncontrado= _appContext.Accidente.FirstOrDefault(p => p.id==accidente.id);
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
