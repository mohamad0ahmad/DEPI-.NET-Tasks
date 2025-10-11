using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class StuCrsRes
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public int Grade { get; set; }
    }
}
