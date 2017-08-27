using System;
using System.Linq;
using DomainModel.Model;
using Microsoft.EntityFrameworkCore;
using TakeMyNote.Data.Model;

namespace TakeMyNote.Data
{
    // >dotnet ef migration add testMigration in AspNet5MultipleProject
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Note>().HasKey(m => m.Id);
            builder.Entity<User>().HasKey(m => m.Id);

            //// shadow properties
            //builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
            //builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");

            base.OnModelCreating(builder);
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