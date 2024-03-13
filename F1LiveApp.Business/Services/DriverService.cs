using F1LiveApp.Business.Interfaces.Repositories;
using F1LiveApp.Business.Interfaces.Services;
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
		private readonly IDriverRepository _driverRepository;

		public DriverService(IDriverRepository driverRepository)
		{
			_driverRepository = driverRepository;
		}

		public Task<IActionResult> GetAllDrivers(int sessionKey)
		{
			throw new NotImplementedException();
		}
	}
}
