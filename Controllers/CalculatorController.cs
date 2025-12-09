using Microsoft.AspNetCore.Mvc;
using SecureApi.Services;

namespace SecureApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator = new Calculator();

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            var result = _calculator.Add(a, b);
            return Ok(result);
        }
    }
}
