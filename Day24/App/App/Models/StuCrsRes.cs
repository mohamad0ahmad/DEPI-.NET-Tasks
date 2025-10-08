using System.ComponentModel.DataAnnotations.Schema;
using App.Models;

public class StuCrsRes
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string? Grade { get; set; }

    // العلاقات (لو موجودة)
    public Student? Student { get; set; }
    public Course? Course { get; set; }
}
