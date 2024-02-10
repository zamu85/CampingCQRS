using Domain.Entities.Alloggio;
using Domain.Entities.Camera;
using Domain.Entities.Elettricita;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence
{
    public class CampingContext : DbContext
    {
        public CampingContext(DbContextOptions<CampingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Camera> Camere { get; set; }

        public DbSet<Elettricita> Elettricita { get; set; }

        public DbSet<Alloggio> Alloggi { get; set; }

        public DbSet<AlloggioPiazzola> Piazzole { get; set; }

        public DbSet<AlloggioAppartamento> Appartamenti { get; set; }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Alloggio>()
            //    .HasOne(e => e.Elettricita)
            //    .WithOne(e => e.Alloggio)
            //    .HasForeignKey<Elettricita>(e => e.Id)
            //    .IsRequired();

            modelBuilder.Entity<Alloggio>()
                .HasMany(e => e.NoteAggiuntive)
                .WithOne(e => e.Alloggio)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}