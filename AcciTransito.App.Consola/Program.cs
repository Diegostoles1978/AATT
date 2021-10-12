
using System;
using AcciTransito.App.Dominio.Entidades;
using AcciTransito.App.Persistencia;

namespace AcciTransito.App.Consola
{
    class Program
    {

        private static IRepositorioPersonas _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        private static IRepositorioAccidente _repoAccidentes = new RepositorioAccidentes(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
<<<<<<< HEAD
           ///AddPersonas();
           ///AddVehiculo();
=======
           AddPersonas();
           AddVehiculos();
           AddAccidentes();
>>>>>>> 332934a842f3b09b93fcbe26844582654c1a79b0


        }
        private static void AddPersonas()
        {
            var personas = new Personas{

                NumeroIdentificacion="53892870",
                Nombres = "Ana Maria",
                Apellidos="Amado",
                FechaNacimiento= new DateTime(2002, 10,01),
                Direccion="Calle 116 No. 9-23",
               // NumeroCelular= 3103467813 ,
                CorreoElectronico="ana.amado@gmail.com",

            };
              var personas1 = new Personas{

                NumeroIdentificacion="9023485",
                Nombres = "Diego",
                Apellidos="Villamizar",
                FechaNacimiento= new DateTime(1980, 05,15),
                Direccion="Calle 63 # 6.9",
                //NumeroCelular= 3103467813 ,
                CorreoElectronico="diegoarlesvc@hotmail.com",

            };
              var personas2 = new Personas{

                NumeroIdentificacion="100236759",
                Nombres = "Cristian",
                Apellidos="Barraza",
                FechaNacimiento= new DateTime(1999, 03,17),
                Direccion="Calle 29 Norte No 3-02",
               // NumeroCelular= 3103467813 ,
                CorreoElectronico="cristian.barraza@gmail.com",

            };


              var personas3= new Personas{

                NumeroIdentificacion="100236759",
                Nombres = "Oscar ",
                Apellidos="Habeych",
                FechaNacimiento= new DateTime(1985, 11,12),
                Direccion="Calle 122 No. 7-10",
                CorreoElectronico="oscar.habeych@gmail.com",

            };
            _repoPersona.AddPersonas(personas);
            _repoPersona.AddPersonas(personas1);
            _repoPersona.AddPersonas(personas2);
            _repoPersona.AddPersonas(personas3);
        }


        private static void AddVehiculos()
        {
            var vehiculo = new Vehiculos{

                Placa="AAB-103",
                Marca = "MAZDA",
                Modelo="2001",
                TipoVehiculo= "Automovil",
                LicenciaTransito="AS200",



            };
              var vehiculo1 = new Vehiculos{

                Placa="BAC-B103",
                Marca = "RENAULT",
                Modelo="2016",
                TipoVehiculo= "Automovil",
                LicenciaTransito="AS201",
            };


            _repoVehiculo.AddVehiculos(vehiculo);
            _repoVehiculo.AddVehiculos(vehiculo1);

        }
            private static void AddAccidentes()
        {
            var accidentes = new Accidentes{


                NumeroAccidente="FC0020",
                Fecha = new DateTime(2021, 10,03),
                Peritaje="El accidente se genero por exceso de velocidad"


            };
             _repoAccidentes.AddAccidente(accidentes);

        }


    }
}


