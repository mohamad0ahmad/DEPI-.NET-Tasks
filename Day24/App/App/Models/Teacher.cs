using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public string Address { get; set; } = string.Empty;

        public int CourseId { get; set; }
        public int DepartmentId { get; set; }

        public Course Course { get; set; } = null!;
        public Department Department { get; set; } = null!;
    }
}
