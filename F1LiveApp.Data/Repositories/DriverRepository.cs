using F1LiveApp.Business.Interfaces.Repositories;
using F1LiveApp.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Data.Repositories
{
	public class DriverRepository : IDriverRepository
	{
		private readonly DataContext _dataContext;

		public DriverRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
	}
}
