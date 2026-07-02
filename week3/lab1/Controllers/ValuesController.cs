using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET Request Executed Successfully");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST Request Executed Successfully");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("PUT Request Executed Successfully");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE Request Executed Successfully");
        }
    }
}