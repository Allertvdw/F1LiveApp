using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Models
{
	public class Meeting
	{
        public int CircuitKey { get; set; }
        public string CircuitShortName { get; set; }
        public string CountryCode { get; set; }
        public int CountryKey { get; set; }
        public string CountryName { get; set; }
        public DateTime DateStart { get; set; }
        public TimeSpan GmtOffset { get; set; }
        public string Location { get; set; }
        public int MeetingKey { get; set; }
        public string MeetingName { get; set; }
        public string MeetingOfficialName { get; set; }
        public int Year { get; set; }
    }
}
