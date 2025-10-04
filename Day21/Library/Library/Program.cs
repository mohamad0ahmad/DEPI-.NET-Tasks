using System;
using System.Linq;
using Library.DbContect;
using Library.Models;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using LibraryDbContext context = new LibraryDbContext();

            context.Database.EnsureCreated();

            if (!context.Authors.Any())
            {
                var author = new Author { Name = "George Orwell", BirthDate = new DateTime(1903, 6, 25) };
                var book1 = new Book { Title = "1984", ISBN = "9780451524935", Author = author };
                var book2 = new Book { Title = "Animal Farm", ISBN = "9780451526342", Author = author };

                var borrower = new Borrower { Name = "Alice", MembershipDate = DateTime.Now.AddYears(-1) };

                var loan = new Loan
                {
                    Book = book1,
                    Borrower = borrower,
                    LoanDate = DateTime.Now.Date,
                    ReturnDate = null
                };

                context.Add(author);
                context.Add(book1);
                context.Add(book2);
                context.Add(borrower);
                context.Add(loan);

                context.SaveChanges();
                Console.WriteLine("Seeded sample library data.");
            }

            var books = context.Books
                               .Select(b => new { b.Id, b.Title, AuthorName = b.Author.Name })
                               .ToList();

            Console.WriteLine("Books in library:");
            foreach (var b in books)
                Console.WriteLine($"{b.Id}: {b.Title} - {b.AuthorName}");
        }
    }
}
