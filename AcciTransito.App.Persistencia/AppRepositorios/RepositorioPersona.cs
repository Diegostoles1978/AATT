

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersonas {
        ///<summary>
        ///Referencia al contexto de personas
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Personas AddPersonas(Personas personas) {
            var personasAdicionar=_appContext.Personas.Add(personas);
            _appContext.SaveChanges();
            return personasAdicionar.Entity;

        }

        void IRepositorioPersonas.DeletePersonas(int id) {
            var personasEncontrada=_appContext.Personas.FirstOrDefault(p => p.id==id);
            if(personasEncontrada==null)
            return;
            _appContext.Personas.Remove(personasEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<Personas> GetAllPersonas() {
          return _appContext.Personas;
        }

        public Personas GetPersonas(int id) {
          return _appContext.Personas.FirstOrDefault (p => p.id==id);
        }

        public Personas UpdatePersonas(Personas personas) {
            var personasEncontrada= _appContext.Personas.FirstOrDefault(p => p.id==personas.id);
            if (personasEncontrada!=null)
            {
                personasEncontrada.NumeroIdentificacion=personas.NumeroIdentificacion;
                personasEncontrada.Nombre=personas.Nombre;
                personasEncontrada.Apellidos=personas.Apellidos;
                personasEncontrada.FechaNacimiento=personas.FechaNacimiento;
                personasEncontrada.Direccion=personas.Direccion;
                personasEncontrada.NumeroCelular=personas.NumeroCelular;
                 personasEncontrada.CorreoElectronico=personas.CorreoElectronico;
                personasEncontrada.Genero=personas.Genero;

                _appContext.SaveChanges();

            }

             return personasEncontrada;
        }

    }
}
