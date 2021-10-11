

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersonas {
        /*  ///<summary>
        ///Referencia al contexto de personas
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioPersona(AppContext appContext) {
            _appContext = appContext;
        }
         public Personas AddPersonas(Personas personas) {
            var personasAdicionar = _appContext.Personas.Add(personas);
            _appContext.SaveChanges();
            return personasAdicionar.Entity;

        }

        void IRepositorioPersonas.DeletePersonas(int id) {
            var personasEncontrada = _appContext.Personas.FirstOrDefault(p => p.id == id);
            if (personasEncontrada == null)
                return;
            _appContext.Personas.Remove(personasEncontrada);
            _appContext.SaveChanges();
        }
 */
         List<Personas> personas;

        public RepositorioPersona()
        {
            personas= new List<Personas>()

            {
                 new Personas{id=1, NumeroIdentificacion="100236759",
                Nombres = "Cristian",
                Apellidos="Barraza",
                FechaNacimiento= new DateTime(1999, 03,17),
                Direccion="Calle 29 Norte No 3-02",
               // NumeroCelular= 3103467813 ,
                CorreoElectronico="cristian.barraza@gmail.com"},
                new Personas{id=2, NumeroIdentificacion="9023485",
                Nombres = "Diego",
                Apellidos="Villamizar",
                FechaNacimiento= new DateTime(1980, 05,15),
                Direccion="Calle 63 # 6.9",
                //NumeroCelular= 3103467813 ,
                CorreoElectronico="diegoarlesvc@hotmail.com"},
                new Personas{id=3, NumeroIdentificacion="53892870",
                Nombres = "Ana Maria",
                Apellidos="Amado",
                FechaNacimiento= new DateTime(2002, 10,01),
                Direccion="Calle 116 No. 9-23",
               // NumeroCelular= 3103467813 ,
                CorreoElectronico="ana.amado@gmail.com"}


            };
        }

        public IEnumerable<Personas> GetAll() {
            return personas;
          //  return _appContext.Personas;
        }

       /*  public Personas GetPersonas(int id) {
            return _appContext.Personas.FirstOrDefault(p => p.id == id);
        }

        public Personas UpdatePersonas(Personas personas) {
            var personasEncontrada = _appContext.Personas.FirstOrDefault(p => p.id == personas.id);
            if (personasEncontrada != null) {
                personasEncontrada.NumeroIdentificacion = personas.NumeroIdentificacion;
                personasEncontrada.Nombres = personas.Nombres;
                personasEncontrada.Apellidos = personas.Apellidos;
                personasEncontrada.FechaNacimiento = personas.FechaNacimiento;
                personasEncontrada.Direccion = personas.Direccion;
                personasEncontrada.NumeroCelular = personas.NumeroCelular;
                personasEncontrada.CorreoElectronico = personas.CorreoElectronico;
                personasEncontrada.Genero = personas.Genero;

                _appContext.SaveChanges();

            }

            return personasEncontrada;
        }
 */
        }

    }

