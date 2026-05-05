using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new List<string>
            {
                "Ash",
                "John",
                "Emma"
            };

            return Ok(students);
        }
    }
}