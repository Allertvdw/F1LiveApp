using F1LiveApp.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Interfaces.Services
{
	public interface IDriverService
	{
		Task<IActionResult> GetAllDrivers(int sessionKey);
	}
}
