using MVC_School.Data.DbContexts;
using MVC_School.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_School.Models
{
    public class DepartmentBL
    {
        private readonly SchoolDbContext _context;

        public DepartmentBL(SchoolDbContext context)
        {
            _context = context;
        }

        // Get All Departments
        public List<Department> GetAll()
        {
            return _context.Departments.Include(d => d.Students)
                                       .Include(d => d.Teachers)
                                       .Include(d => d.Courses)
                                       .ToList();
        }

        // Get Department By Id
        public Department GetById(int id)
        {
            return _context.Departments.Include(d => d.Students)
                                       .Include(d => d.Teachers)
                                       .Include(d => d.Courses)
                                       .FirstOrDefault(d => d.Id == id);
        }

        // Add Department
        public void AddDept(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        // Update Department
        public void UpdateDept(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
        }

        // Delete Department
        public void DeleteDept(int id)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}
