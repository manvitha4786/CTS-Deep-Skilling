using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GetEmployees());
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id=1,
                    Name="John",
                    Salary=50000,
                    Permanent=true,
                    DateOfBirth=new DateTime(1998,5,10),

                    Department=new Department
                    {
                        Id=101,
                        Name="IT"
                    },

                    Skills=new List<Skill>()
                    {
                        new Skill
                        {
                            Id=1,
                            Name="C#"
                        },
                        new Skill
                        {
                            Id=2,
                            Name="SQL"
                        }
                    }
                }
            };
        }
    }
}