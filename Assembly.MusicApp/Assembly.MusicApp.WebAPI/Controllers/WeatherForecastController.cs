using Microsoft.AspNetCore.Mvc;

namespace Assembly.MusicApp.WebAPI.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
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

        [HttpPost]
        public void AddEntity(WeatherForecast weatherForecast)
        {

        }

        [HttpPut]
        [Route("update")]
        public void UpdateEntity(WeatherForecast weatherForecast)
        {

        }

        [HttpDelete]
        [Route("delete")]
        public void DeleteEntity(WeatherForecast weatherForecast)
        {

        }
    }

    class UserDto
    {
        public int MyProperty { get; set; }
    }
}