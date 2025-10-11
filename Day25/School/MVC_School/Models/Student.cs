using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public List<StuCrsRes>? StuCrsResList { get; set; }
    }
}
