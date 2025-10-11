using Microsoft.AspNetCore.Mvc;
using MVC_School.Models;

namespace MVC_School.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentBL _departmentBL;

        public DepartmentController(DepartmentBL departmentBL)
        {
            _departmentBL = departmentBL;
        }

        // /Department/ShowAll
        public IActionResult ShowAll()
        {
            var departments = _departmentBL.GetAll();
            return View(departments);
        }

        // /Department/ShowDetails?id=3
        public IActionResult ShowDetails(int id)
        {
            var department = _departmentBL.GetById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        // /Department/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // /Department/Add
        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentBL.AddDept(department);
                return RedirectToAction(nameof(ShowAll));
            }
            return View(department);
        }
    }
}
