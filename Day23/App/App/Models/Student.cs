using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        // Navigation
        public Department Department { get; set; }
        public ICollection<StuCrsRes> StuCrsRes { get; set; }
    }
}
