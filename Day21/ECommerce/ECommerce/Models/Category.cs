using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Categories")]
    internal class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), StringLength(100)]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
