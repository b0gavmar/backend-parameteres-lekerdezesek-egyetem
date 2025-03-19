using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly SchoolContext _context = new SchoolContext();

        [HttpGet("StudentsOfDepartment")]
        public async Task<IActionResult> GetStudentsOfDepartmentAsync([FromQuery] string departmentName)
        {
            //query format, sqlinjecktion mukodik rajta szoval nem biztonsagos
            /*var result = await (from s in _context.Students
                                from d in _context.Departments
                                where d.Id == s.DepartmentId && d.Name == departmentName
                                select s.Name).ToListAsync();
            */

            //method format
            var result = _context.Students
                .Join(_context.Departments, s=> s.DepartmentId, d => d.Id, (s, d) => new { Student = s, Department = d })
                .Where(sd => sd.Department.Name == departmentName)
                .Select(sd => sd.Student.Name)
                .ToListAsync().Result;

            return Ok(result);
        }

        [HttpGet("students/count")]
        public async Task<IActionResult> GetNumberOfStudentsAsync()
        {
            return Ok(_context.Students.Count());
        }

        [HttpGet("courses/{course_id}/students/count")]
        public async Task<IActionResult> GetNumberOfStudentsInACourseAsync(int course_id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == course_id);
            var department = await _context.Departments.FirstOrDefaultAsync(d => d.Id == course.DepartmentId);
            return Ok(_context.Students.Where(s => s.DepartmentId == department.Id).Count());
        }

        [HttpGet("teachers/count")]
        public async Task<IActionResult> GetNumberOfTeachersAsync()
        {
            return Ok(_context.Teachers.Count());
        }

        [HttpGet("departments/{department_id}/students/count")]
        public async Task<IActionResult> GetNumberOfStudentsInADepartmentAsync(int department_id)
        {
            return Ok(_context.Students.Where(s => s.DepartmentId == department_id).Count());
        }


        [HttpGet("students")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            return Ok(_context.Students.Select(s=> s.Name).ToListAsync().Result);
        }

        [HttpGet("courses")]
        public async Task<IActionResult> GetAllCoursesAsync()
        {
            return Ok(_context.Courses.Select(c => c.Name).ToListAsync().Result);
        }

        [HttpGet("teachers")]
        public async Task<IActionResult> GetAllTeachersAsync()
        {
            return Ok(_context.Teachers.Select(t => t.Name).ToListAsync().Result);
        }


        [HttpGet("departments")]
        public async Task<IActionResult> GetAllDepartmentsAsync()
        {
            return Ok(_context.Departments.Select(d => d.Name).ToListAsync().Result);
        }

        [HttpGet("students?age")]
        public async Task<IActionResult> GetAllStudentsAged20Async([FromQuery] int age = 20)
        {
            var students = await _context.Students.Where(s => s.Age == age).ToListAsync();
            return Ok(students);
        }

    }
}
