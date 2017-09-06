using System;
using System.Linq;
using TakeMyNote.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TakeMyNote.DataAccess
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=mynotes;Pooling=true;");

            return new DatabaseContext(optionsBuilder.Options);

            // TODO: from config file

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var builder = new DbContextOptionsBuilder<CodingBlastDbContext>();
            //var connectionString = configuration.GetConnectionString("DefaultConnection");
            //builder.UseSqlServer(connectionString);
            //return new CodingBlastDbContext(builder.Options);
        }
    }

    public class DummyClass
    {
    
    }
    // >dotnet ef migration add testMigration in AspNet5MultipleProject
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstr = "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=mynotes;Pooling=true;";
            optionsBuilder.UseNpgsql(connstr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<User>().HasKey(m => m.Id);
            modelBuilder.Entity<Note>().HasKey(m => m.Id);

            //// shadow properties
            //builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
            //builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            //ChangeTracker.DetectChanges();

            //updateUpdatedProperty<SourceInfo>();
            //updateUpdatedProperty<DataEventRecord>();

            return base.SaveChanges();
        }

        private void updateUpdatedProperty<T>() where T : class
        {
            var modifiedSourceInfo =
                ChangeTracker.Entries<T>()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in modifiedSourceInfo)
            {
                entry.Property("UpdatedTimestamp").CurrentValue = DateTime.UtcNow;
            }
        }
    }
}