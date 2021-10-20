
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using AcciTransito.App.Dominio.Entidades;

// namespace AcciTransito.App.Persistencia
// {
//     public class RepositorioAccidentesPersonas : IRepositorioAccidentePersonas
//         { ///<summary>
//         ///Referencia al contexto de accidentes
//         ///</summary>
//         private readonly AppContext _appContext;
//         ///<summary>
//         ///Metodo Constructor
//         ///</summary>
//         ///<param name="appContext"></param>//

//         public RepositorioAccidentesPersonas(AppContext appContext) => _appContext = appContext;
//         public Personas_Accidente AddAccidente(Personas_Accidente accidente) {
//             var accidenteperAdicionar=_appContext.Accidentes.Add(Personas_Accidente);
//             _appContext.SaveChanges();
//             return accidenteperAdicionar.Entity;

//         }

//         void IRepositorioAccidentePersonas.DeleteAccidentePersona(int id) {
//             var accidenteperEncontrado=_appContext.Accidentes.FirstOrDefault(p => p.id==id);
//             if(accidenteperEncontrado==null)
//             return;
//             _appContext.Personas_Accidente.Remove(accidenteperEncontrado);
//             _appContext.SaveChanges();
//         }
//         public IEnumerable<Personas_Accidente> GetAllAccidente() {
//           return _appContext.Personas_Accidente;
//         }

//         public Personas_Accidente GetAccidente(int id) {
//           return _appContext.Personas_Accidente.SingleOrDefault (p => p.id==id); //FirstOrDefault
//         }



//         public Personas_Accidente UpdateAccidente(Personas_Accidente accidente) {
//             var accidenteEncontrado= _appContext.Personas_Accidente.FirstOrDefault(p => p.id==accidente.id);
//             if (accidenteEncontrado!=null)
//             {
//                 accidenteEncontrado.Persona;
//                 accidenteEncontrado.accidente;


//                 _appContext.SaveChanges();

//             }

//              return accidenteEncontrado;
//         }

//     }
// }
