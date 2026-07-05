using EmployeeManagementApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementApi.Filters;

namespace EmployeeManagementApi.Controllers
{
    //[CustomAuthFilter]
    [CustomExceptionFilter]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Private method to return employee list
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Jayesh",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(2000, 5, 10),

                    Department = new Department
                    {
                        Id = 101,
                        Name = "IT"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Salary = 45000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1999, 8, 20),

                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Communication" }
                    }
                }
            };
        }

        // GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {

            throw new Exception("This is a custom exception.");

            //return Ok(GetStandardEmployeeList());
        }

        // POST
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            return Ok(employee);
        }

        // PUT
        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            return Ok(employee);
        }
    }
}