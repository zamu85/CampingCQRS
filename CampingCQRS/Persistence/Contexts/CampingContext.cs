using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class CampingContext : DbContext
    {
        public CampingContext(DbContextOptions<CampingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Domain.Camera.Camera> Camere { get; set; }

        public DbSet<Domain.Elettricita.Elettricita> Elettricita { get; set; }

        public DbSet<Domain.Alloggio.Alloggio> Alloggi { get; set; }

        public DbSet<Domain.Alloggio.AlloggioPiazzola> Piazzole { get; set; }

        public DbSet<Domain.Alloggio.AlloggioAppartamento> Appartamenti { get; set; }

        protected override void OnDomainCreating(DomainBuilder DomainBuilder)
        {



        }
    }
}