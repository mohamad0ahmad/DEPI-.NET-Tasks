using MVC_School.Data.DbContexts;
using MVC_School.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_School.Models
{
    public class StudentBL
    {
        private readonly SchoolDbContext _context;

        public StudentBL(SchoolDbContext context)
        {
            _context = context;
        }

        // Get All Students
        public List<Student> GetAll()
        {
            return _context.Students.Include(s => s.Department).ToList();
        }

        // Get Student By Id
        public Student GetById(int id)
        {
            return _context.Students.Include(s => s.Department)
                                    .FirstOrDefault(s => s.Id == id);
        }

        // Add Student
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // Update Student
        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        // Delete Student
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        // Get Students by Department Id
        public List<Student> GetStudentsByDepartment(int departmentId)
        {
            return _context.Students.Where(s => s.DepartmentId == departmentId).ToList();
        }

        // Get Students older than 25
        public List<Student> GetStudentsOlderThan25()
        {
            return _context.Students.Where(s => s.Age > 25).ToList();
        }
    }
}
