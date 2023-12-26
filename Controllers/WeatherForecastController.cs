using Microsoft.AspNetCore.Mvc;

namespace Walkthrough.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetV2")]
        public string GetV2()
        {
            return "Version 2 Running.";
        }

        [HttpGet("GetV3")]
        public string GetV3()
        {
            return "Version 3 Running.";
        }

        [HttpGet("GetDev")]
        public string GetDev()
        {
            return "Version Dev Running.";
        } 
        
        [HttpGet("GetV4")]
        public string GetV4()
        {
            return "Version V4 Running.";
        }
    }
}
