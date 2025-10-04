using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("Authors")]
    internal class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public List<Book> Books { get; set; }
    }
}
