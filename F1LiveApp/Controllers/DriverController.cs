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
		private readonly IDriverService _driverService;

		public DriverController(IDriverService driverService)
		{
			_driverService = driverService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllDrivers(int sessionKey)
		{
			List<Driver> drivers = await _driverService.GetAllDrivers(sessionKey);
			return Ok(drivers);
		}
	}
}
