using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;


namespace AcciTransito.App.Persistencia
{
    public class RepositorioAccidente : IRepositorioAccidente
    {

        private readonly AppContext _appContext;
        public RepositorioAccidente(AppContext appContext)

        {
            _appContext=appContext;
        }
        Accidente IRepositorioAccidente.AddAccidente(Accidente accidente)
        {

            var accidenteAdicionado = _appContext.Accidentes.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionado.Entity;
        }

        void IRepositorioAccidente.DeleteAccidente(int id)
        {

            var accidenteEncontrado = _appContext.Accidentes.FirstOrDefault(a => a.id == id);
            if(accidenteEncontrado == null)

                return;

            _appContext.Accidentes.Remove(accidenteEncontrado);

            _appContext.SaveChanges();

        }
        IEnumerable<Accidente> IRepositorioAccidente.GetAllAccidentes()

        {
            return _appContext.Accidentes;
        }

        Accidente IRepositorioAccidente.GetAccidente(int id)
        {
            return _appContext.Accidentes.FirstOrDefault(a => a.id==id);
        }

        Accidente IRepositorioAccidente.UpdateAccidente(Accidente accidente)

        {
            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(a => a.id == accidente.id);
            if (accidenteEncontrado!=null)
            {

                accidenteEncontrado.NumeroAccidente = accidente.NumeroAccidente;
                accidenteEncontrado.Fecha = accidente.Fecha;
                accidenteEncontrado.Peritaje = accidente.Peritaje;
                accidenteEncontrado.Croquis = accidente.Croquis;
                accidenteEncontrado.IdCoordenasid = accidente.IdCoordenasid;
                accidenteEncontrado.Vehiculosid = accidente.Vehiculosid;
                accidenteEncontrado.AgenteTransitoid = accidente.AgenteTransitoid;

                _appContext.SaveChanges();

            }
                return accidenteEncontrado;

        }

    }

}