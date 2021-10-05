
using System;
using AcciTransito.App.Dominio.Entidades;
using AcciTransito.App.Persistencia;

namespace AcciTransito.App.Consola
{
    class Program
    {

        private static IRepositorioPersonas _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           ///AddPersonas();
           AddVehiculo();


        }
        private static void AddPersonas()
        {
            var personas = new Personas{

                NumeroIdentificacion="53892870",
                Nombre = "Ana Maria",
                Apellidos="Amado",
                FechaNacimiento= new DateTime(2002, 10,01),
                Direccion="Calle 116 No. 9-23",
                //NumeroCelular= 3103467813 ,
                CorreoElectronico="ana.amado@gmail.com",

            };
              var personas1 = new Personas{

                NumeroIdentificacion="9023485",
                Nombre = "Diego",
                Apellidos="Villamizar",
                FechaNacimiento= new DateTime(1980, 05,15),
                Direccion="Calle 63 # 6.9",
                //NumeroCelular= 3103467813 ,
                CorreoElectronico="diegoarlesvc@hotmail.com",

            };
              var personas2 = new Personas{

                NumeroIdentificacion="100236759",
                Nombre = "Cristian",
                Apellidos="Barraza",
                FechaNacimiento= new DateTime(1999, 03,17),
                Direccion="Calle 29 Norte No 3-02",
                //NumeroCelular= 3103467813 ,
                CorreoElectronico="cristian.barraza@gmail.com",

            };


              var personas3= new Personas{

                NumeroIdentificacion="100236759",
                Nombre = "Oscar ",
                Apellidos="Habeych",
                FechaNacimiento= new DateTime(1985, 11,12),
                Direccion="Calle 122 No. 7-10",
                //Genero
                CorreoElectronico="oscar.habeych@gmail.com",

            };
            _repoPersona.AddPersonas(personas);
            _repoPersona.AddPersonas(personas1);
             _repoPersona.AddPersonas(personas2);
              _repoPersona.AddPersonas(personas3);
        }


        private static void AddVehiculo()
        {
            var vehiculo = new Vehiculo{

                Placa="AAB-103",
                Marca = "MAZDA",
                Modelo="2001",
                TipoVehiculo= "Automovil",
                LicenciaTransito="AS200",



            };
              var vehiculo1 = new Vehiculo{

                Placa="BAC-B103",
                Marca = "RENAULT",
                Modelo="2016",
                TipoVehiculo= "Automovil",
                LicenciaTransito="AS201",


            };

            _repoVehiculo.AddVehiculo(vehiculo);
            _repoVehiculo.AddVehiculo(vehiculo1);


        }


    }
}


