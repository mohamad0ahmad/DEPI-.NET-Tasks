using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 /Department/ShowAll
        public async Task<IActionResult> ShowAll()
        {
            var departments = await _context.Departments
                .Include(d => d.Students)
                .ToListAsync();

            return View(departments);
        }

        // 🔹 /Department/ShowDetails/3
        public async Task<IActionResult> ShowDetails(int id)
        {
            var department = await _context.Departments
                .Include(d => d.Students)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (department == null)
                return NotFound();

            var vm = new DepartmentViewModel
            {
                DepartmentName = department.Name,
                StudentNamesOver25 = department.Students
                    .Where(s => s.Age > 25)
                    .Select(s => s.Name)
                    .ToList(),
                DepartmentState = department.Students.Count > 50 ? "Main" : "Branch"
            };

            return View(vm);
        }

        // 🔹 GET: /Department/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // 🔹 POST: /Department/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction("ShowAll");
            }

            return View(department);
        }
    }
}
