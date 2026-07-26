using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[]
            {
                "Value1",
                "Value2"
            });
        }

        // GET by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Value = {id}");
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Data Added Successfully");
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok($"Updated Value {id}");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted Value {id}");
        }
    }
}