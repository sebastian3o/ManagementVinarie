using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ManagementVinarie.Data
{
    public class VinarieContext : DbContext
    {
        public DbSet<Models.Servicii.Client> Clienti { get; set; }
        public DbSet<Models.Servicii.Pachet> Pachete { get; set; }
        public DbSet<Models.Servicii.Rezervare> Rezervari { get; set; }
        public DbSet<Models.Servicii.SalaDegustare> SaliDegustare { get; set; }
        public DbSet<Models.Vin.CantitateZahar> CantitatiZahar { get; set; }
        public DbSet<Models.Vin.ClasificareVin> ClasificariVin { get; set; }
        public DbSet<Models.Vin.Culoare> Culori { get; set; }
        public DbSet<Models.Vin.CalitateStruguri> CalitatiStruguri { get; set; }
        public DbSet<Models.Vin.ContinutAlcool> ContinuturiAlcool { get; set; }
        public DbSet<Models.Vin.Vin> Vinuri { get; set; }

     
      


       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=Vinarie.db");

        public VinarieContext()
        {
            
            Database.EnsureCreated();
            
        }


    }
}
