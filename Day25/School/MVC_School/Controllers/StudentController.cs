using Microsoft.AspNetCore.Mvc;
using MVC_School.Models;

namespace MVC_School.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentBL _studentBL;
        private readonly DepartmentBL _departmentBL;

        public StudentController(StudentBL studentBL, DepartmentBL departmentBL)
        {
            _studentBL = studentBL;
            _departmentBL = departmentBL;
        }

        // /Student/ShowAll
        public IActionResult ShowAll(string searchTerm, int departmentId = 0, int page = 1)
        {
            // Get all students
            var students = _studentBL.GetAll();

            // Ensure that ViewData["Departments"] is populated
            ViewData["Departments"] = _departmentBL.GetAll();

            // Filter by department
            if (departmentId > 0)
            {
                students = students.Where(s => s.DepartmentId == departmentId).ToList();
            }

            // Search functionality
            if (!string.IsNullOrEmpty(searchTerm))
            {
                students = students.Where(s => s.Name.Contains(searchTerm)).ToList();
            }

            // Pagination
            int pageSize = 10;
            int totalStudents = students.Count();
            students = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewData["TotalPages"] = Math.Ceiling((double)totalStudents / pageSize);
            ViewData["CurrentPage"] = page;

            return View(students); // Pass the students list to the view
        }


        // /Student/ShowDetails?id=3
        public IActionResult ShowDetails(int id)
        {
            var student = _studentBL.GetById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // /Student/Add
        [HttpGet]
        public IActionResult Add()
        {
            ViewData["Departments"] = _departmentBL.GetAll();
            return View();
        }

        // /Student/Add
        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentBL.AddStudent(student);
                return RedirectToAction(nameof(ShowAll));
            }

            ViewData["Departments"] = _departmentBL.GetAll();
            return View(student);
        }

        // /Student/Edit?id=3
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentBL.GetById(id);
            if (student == null)
                return NotFound();

            ViewData["Departments"] = _departmentBL.GetAll();
            return View(student);
        }

        // /Student/Edit
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentBL.UpdateStudent(student);
                return RedirectToAction(nameof(ShowAll));
            }

            ViewData["Departments"] = _departmentBL.GetAll();
            return View(student);
        }

        // /Student/Delete?id=3
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _studentBL.GetById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // /Student/ConfirmDelete
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            _studentBL.DeleteStudent(id);
            return RedirectToAction(nameof(ShowAll));
        }
    }
}
