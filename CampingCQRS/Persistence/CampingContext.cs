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

        public DbSet<Model.Camera.Camera> Camere { get; set; }

        public DbSet<Model.Elettricita.Elettricita> Elettricita { get; set; }

        public DbSet<Model.Alloggio.Alloggio> Alloggi { get; set; }

        public DbSet<Model.Alloggio.AlloggioPiazzola> Piazzole { get; set; }

        public DbSet<Model.Alloggio.AlloggioAppartamento> Appartamenti { get; set; }
    }
}