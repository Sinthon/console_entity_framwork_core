using Microsoft.EntityFrameworkCore;

using console_entity_framwork_core.Models;

namespace console_entity_framwork_core.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Client>? Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=console_entity_framework_core; Trusted_Connection=true; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new {
                ClientRefId = "e560dba8bdd2453d97ec2e3ddf2ca2f8",
                ClientSecret = "e560dba8bdd2453d97ec2e3ddf2ca2f8"
            });
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
