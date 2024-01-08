using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;


namespace EFCoreCodeFirstDemoApp.Entities
{
    internal class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = $"Host=localhost;Port=5432;Database=TestEfCore;User Id=postgres;Password={Environment.GetEnvironmentVariable("sql_root")};";
            optionsBuilder.UseNpgsql(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
