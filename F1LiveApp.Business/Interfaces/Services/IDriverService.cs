﻿using F1LiveApp.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Interfaces.Services
{
	public interface IDriverService
	{
		Task<List<Driver>> GetAllDrivers(int sessionKey);
	}
}
