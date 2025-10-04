using Library.ConfigurationClasses;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Library.DbContect
{
    internal class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LibraryDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            modelBuilder.Entity<Loan>()
                .HasKey(l => new { l.BookId, l.BorrowerId, l.LoanDate });

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Loans)
                .WithOne(l => l.Book)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Borrower>()
                .HasMany(br => br.Loans)
                .WithOne(l => l.Borrower)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Cascade);

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
