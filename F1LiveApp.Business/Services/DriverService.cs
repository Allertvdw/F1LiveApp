using F1LiveApp.Business.Interfaces.Repositories;
using F1LiveApp.Business.Interfaces.Services;
using F1LiveApp.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Services
{
	public class DriverService : IDriverService
	{
		private readonly IDriverClient _driverClient;

		public DriverService(IDriverClient driverClient)
		{
			_driverClient = driverClient;
		}

		public async Task<List<Driver>> GetAllDrivers(int sessionKey)
		{
			return await _driverClient.GetAllDrivers(sessionKey);
		}
	}
}
