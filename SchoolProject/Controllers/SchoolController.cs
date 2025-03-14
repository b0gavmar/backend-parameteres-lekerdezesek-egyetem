using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
