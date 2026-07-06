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
        private static List<Employee> employees = new List<Employee>
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
        
        

        // GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {

           // throw new Exception("This is a custom exception.");

            return Ok(employees);
        }

        // POST
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            return Ok(employee);
        }

        // PUT
        [HttpPut]
        public ActionResult<Employee> Put(Employee employee)
        {
            // Check if ID is invalid
            if (employee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Find employee using ID
            Employee? emp = employees.FirstOrDefault(e => e.Id == employee.Id);

            // If employee not found
            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee details
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.DateOfBirth = employee.DateOfBirth;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;

            // Return updated employee
            return Ok(emp);
        }
    }
}