using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Accidentes> Accidentes {get;set;}
        public DbSet<AgenteTransito> AgenteTransito {get;set;}
        public DbSet<Personas> Personas {get;set;}

        public DbSet<Personas_Accidente> Personas_Accidente {get;set;}
        public DbSet<Genero> Genero {get;set;}
        public DbSet<Coordenadas> Coordenadas {get;set;}
        public DbSet<Vehiculos> Vehiculos {get;set;}
        public DbSet<Vehiculos_Accidente> Vehiculos_Accidente {get;set;}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
         {

         optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AccidentesTransito");
         }
    }
    }

}
