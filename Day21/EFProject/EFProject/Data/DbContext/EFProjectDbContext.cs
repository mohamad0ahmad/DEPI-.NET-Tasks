using Microsoft.EntityFrameworkCore;
using EFProject.Models;

namespace EFProject.Data
{
    public class EFProjectDbContext : DbContext
    {
        public EFProjectDbContext(DbContextOptions<EFProjectDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StuCrsRes>()
                .HasKey(s => new { s.StudentId, s.CourseId }); // Composite Key
        }
    }
}
