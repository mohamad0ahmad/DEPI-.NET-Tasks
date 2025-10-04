using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("Loans")]
    internal class Loan
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Borrower")]
        public int BorrowerId { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
    }
}
