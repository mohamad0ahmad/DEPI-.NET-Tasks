namespace MVC_School.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MgrName { get; set; }

        // Navigation properties
        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
