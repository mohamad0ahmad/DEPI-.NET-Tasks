using Microsoft.EntityFrameworkCore;
using Project.Configuration_Classes;
using Project.Models;

namespace Project.DbContext
{
    internal class ProjectDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProjectDB;Trusted_Connection=True;");
        }

        // DbSets
        public DbSet<Project.Models.Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfigurations());
        }
    }
}
