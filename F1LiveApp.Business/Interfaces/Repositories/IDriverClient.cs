using F1LiveApp.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Interfaces.Repositories
{
	public interface IDriverClient
	{
		Task<List<Driver>> GetAllDrivers(int sessionKey);
	}
}
