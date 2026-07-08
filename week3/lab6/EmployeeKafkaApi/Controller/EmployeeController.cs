using EmployeeKafkaApi.Models;
using EmployeeKafkaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeKafkaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly KafkaProducerService _producer;

        public EmployeeController(KafkaProducerService producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Employee employee)
        {
            await _producer.ProduceMessage(employee);

            return Ok(employee);
        }
    }
}