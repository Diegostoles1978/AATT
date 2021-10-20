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
        public DbSet<Coordenadas> Coordenadas {get;set;}
        public DbSet<Vehiculos> Vehiculos {get;set;}
        public DbSet<Vehiculos_Accidente> Vehiculos_Accidente {get;set;}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
         {

        optionsBuilder.UseSqlServer("Server=tcp:missiontic2022.database.windows.net,1433;Initial Catalog=Accidentes_Transito;Persist Security Info=False;User ID=admin_01;Password=Siniestros4*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        //  optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Accidentes_Transito");
         }
    }
    }

}
