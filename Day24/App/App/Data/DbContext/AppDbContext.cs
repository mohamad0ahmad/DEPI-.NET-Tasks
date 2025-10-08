using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 🔹 أضف هذا السطر بالضبط:
            modelBuilder.Entity<StuCrsRes>()
                .HasKey(s => new { s.StudentId, s.CourseId });
        }
    }
}
