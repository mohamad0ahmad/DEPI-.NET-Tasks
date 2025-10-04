using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("Borrowers")]
    internal class Borrower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        public DateTime MembershipDate { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
