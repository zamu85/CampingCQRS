using Domain.Entities.Alloggio;
using Domain.Entities.Camera;
using Domain.Entities.Elettricita;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace Persistence
{
    public class CampingContext : DbContext
    {
        private readonly int LATEST_DATABASE_VERSION = 1;

        public CampingContext(DbContextOptions<CampingContext> options) : base(options)
        {
            Database.EnsureCreated();
            UpdateDatabaseIfRequired();
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

        private void UpdateDatabaseIfRequired()
        {
            long currentDbVersion = Database.SqlQueryRaw<long>("PRAGMA user_version")
                .AsEnumerable().FirstOrDefault();
            
            if (LATEST_DATABASE_VERSION > currentDbVersion)
            {
                var upgradeToDbVersion = currentDbVersion + 1;
                switch(upgradeToDbVersion)
                {
                    case 1:
                        UpgradeToOne();
                        break;
                    default:
                        Database.EnsureCreated();
                        break;
                }
            }

            Database.ExecuteSqlRaw($"PRAGMA user_version={LATEST_DATABASE_VERSION}");
        }

        private void UpgradeToOne()
        {
            string alterCommand = $"ALTER TABLE Camere ADD DogFriendly INTEGER;";

            int rows_affected = Database.ExecuteSqlRaw(alterCommand);
            Debug.WriteLine(rows_affected);
        }
    }
}