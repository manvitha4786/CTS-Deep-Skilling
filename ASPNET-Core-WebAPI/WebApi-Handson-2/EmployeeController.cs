using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Department = "IT",
                Salary = 50000
            },

            new Employee
            {
                Id = 2,
                Name = "David",
                Department = "HR",
                Salary = 45000
            }
        };

        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        // POST
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            employees.Add(employee);

            return Ok("Employee Added Successfully");
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            emp.Name = employee.Name;
            emp.Department = employee.Department;
            emp.Salary = employee.Salary;

            return Ok("Employee Updated Successfully");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            employees.Remove(emp);

            return Ok("Employee Deleted Successfully");
        }
    }
}