using System.Collections.Generic;

namespace App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        // Navigation
        public Department Department { get; set; } = null!;
        public ICollection<StuCrsRes> StuCrsRes { get; set; } = new List<StuCrsRes>();
    }
}
