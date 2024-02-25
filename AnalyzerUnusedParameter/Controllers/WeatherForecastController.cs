using Microsoft.AspNetCore.Mvc;

namespace AnalyzerUnusedParameter.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{

	/// <param name="requestModel">A complex type with appropriate [From*] attributes.</param>
	/// <remarks>This route template will generate an ASP0018 message, despite <see cref="RequestModel"/> including the 
	/// required [FromRoute] attribute to bind the route parameter.</remarks>
	[HttpGet("{filter?}", Name = "GetWeatherForecast")]
	public IActionResult Get(RequestModel requestModel) //even adding [Bind] does not resolve the analyzer suggestion
	{
		logger.LogInformation("Request model value: {Filter}", requestModel.Filter ?? "not set");
		return Ok(new { requestModel.Filter });
	}
}
