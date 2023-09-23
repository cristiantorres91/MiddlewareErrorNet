using Microsoft.AspNetCore.Mvc;

namespace MiddlewareError.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }




        [HttpGet(Name = "GetCalculate")]
        public IActionResult Get(int num1, int num2)
        {

            if(num2 == 0)
                throw new ApplicationException("No se permite la división entre 0");

            var sum = num1 / num2;
            return Ok(new { result = sum });

        }
    }
}