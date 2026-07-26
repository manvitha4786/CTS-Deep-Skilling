using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;
using FirstWebAPI.Filters;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
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

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("Sample Exception");

            //return Ok(GetStandardEmployeeList());
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok(GetStandardEmployeeList().FirstOrDefault(e => e.Id == id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}