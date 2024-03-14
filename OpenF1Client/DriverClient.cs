using F1LiveApp.Business.Interfaces.Repositories;
using F1LiveApp.Business.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenF1Client
{
	public class DriverClient : IDriverClient
	{
		private readonly HttpClient _httpClient;

		public DriverClient()
		{
			_httpClient = new HttpClient()
			{
				BaseAddress = new Uri("https://api.openf1.org/v1/")
			};
		}

		public async Task<List<Driver>> GetAllDrivers(int sessionKey)
		{
			try
			{
				List<Driver> drivers = [];
				HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + $"drivers?session_key={sessionKey}");

				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();
					drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
				}
				else
				{
					throw new Exception("Failed to retrieve drivers from the API.");
				}

				return drivers;
			}
			catch (Exception ex)
			{
				throw new Exception($"An error occurred while retrieving drivers: {ex.Message}");
			}
		}
	}
}
