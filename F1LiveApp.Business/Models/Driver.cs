using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Models
{
	public class Driver
	{
        public string BroadcastName { get; set; }
        public string CountryCode { get; set; }
        public int DriverNumber { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string HeadshotUrl { get; set; }
        public string LastName { get; set; }
        public int MeetingKey { get; set; }
        public string NameAcronym { get; set; }
        public int SessionKey { get; set; }
        public string TeamColour { get; set; }
        public string TeamName { get; set; }
    }
}
