using F1LiveApp.Business.Interfaces.Services;
using F1LiveApp.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace F1LiveApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DriverController : ControllerBase
	{
		private readonly HttpClient _httpClient;

		public DriverController()
		{
			_httpClient = new HttpClient
			{
				BaseAddress = new Uri("https://api.openf1.org/v1/")
			};
		}

		[HttpGet]
		public async Task<IActionResult> GetAllDrivers(int sessionKey)
		{
			try
			{
				List<Driver> drivers = [];
				HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + $"drivers?session_key={sessionKey}");

				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();
					drivers = JsonConvert.DeserializeObject<List<Driver>>(json);

					return Ok(drivers);
				}
				else
				{
					return StatusCode((int)response.StatusCode, "Failed to retrieve drivers from the API.");
				}
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred while retrieving drivers: {ex.Message}");
			}
		}
	}
}
