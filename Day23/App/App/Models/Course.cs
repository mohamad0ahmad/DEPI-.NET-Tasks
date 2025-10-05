using System.Collections.Generic;

namespace App.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        // Navigation
        public Department Department { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<StuCrsRes> StuCrsRes { get; set; }
    }
}
