using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;


namespace ManagementVinarie.Data
{
    public class VinarieContext : DbContext
    {
        public DbSet<Models.Servicii.Client> Clienti { get; set; }
        public DbSet<Models.Servicii.Pachet> Pachete { get; set; }
        public DbSet<Models.Servicii.Rezervare> Rezervari { get; set; }
        public DbSet<Models.Servicii.SalaDegustare> SaliDegustare { get; set; }
        public DbSet<Models.Vin_.CantitateZahar> CantitatiZahar { get; set; }
        public DbSet<Models.Vin_.Clasificare> Clasificari { get; set; }
        public DbSet<Models.Vin_.Culoare> Culori { get; set; }
        public DbSet<Models.Vin_.CalitateStruguri> CalitatiStruguri { get; set; }
        public DbSet<Models.Vin_.ContinutAlcool> ContinuturiAlcool { get; set; }
        public DbSet<Models.Vin_.Vin> Vinuri { get; set; }

     
      


       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=Vinarie2.db");

        public VinarieContext()
        {
            
            Database.EnsureCreated();
            
        }

       


    }
}
