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

        [HttpGet("Students")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            return Ok(_context.Students);
        }

        [HttpGet("NumberOfStudents")]
        public async Task<IActionResult> GetNumberOfStudentsAsync()
        {
            return Ok(_context.Students.Count());
        }

        [HttpGet("Departments")]
        public async Task<IActionResult> GetAllDepartmentsAsync()
        {
            return Ok(_context.Departments);
        }

        [HttpGet("StudentsOfDepartment")]
        public async Task<IActionResult> GetStudentsOfDepartmentAsync([FromQuery] string departmentName)
        {
            var result = await (from s in _context.Students
                             from d in _context.Departments
                             where d.Id == s.DepartmentId && d.Name == departmentName
                             select s.Name).ToListAsync();

            return Ok(result);
            /*_context.Departments.FirstOrDefault(d => d.Name == departmentName);
        return Ok(_context.Departments)*/
            ;
        }

        [HttpGet("Courses")]
        public async Task<IActionResult> GetAllCoursesAsync()
        {
            return Ok(_context.Courses);
        }

        [HttpGet("Teachers")]
        public async Task<IActionResult> GetAllTeachersAsync()
        {
            return Ok(_context.Teachers);
        }
    }
}
