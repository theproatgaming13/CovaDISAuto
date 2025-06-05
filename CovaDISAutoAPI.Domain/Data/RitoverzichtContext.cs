using CovaDISAutoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovaDISAutoAPI.Domain.Data
{
    public class RitoverzichtContext : DbContext
    {
        public RitoverzichtContext(DbContextOptions<RitoverzichtContext> options) : base(options) { }

        public DbSet<Chauffeur>? Chauffeurs { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ritoverzicht> Ritoverzichten { get; set; }
        private ModelBuilder modelBuilder;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ritoverzicht>().HasData(new Ritoverzicht
            {
                // Ritoverzicht instance variabelen invullen
                ID = 1,
                Kilometerstand_voor = 0,
                // Chauffeur = 1, // get Id
                // Route = 1// get Id
            });
        }
    }
}
