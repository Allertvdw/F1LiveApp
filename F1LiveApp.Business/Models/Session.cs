using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Models
{
	public class Session
	{
        [Key]
		public int Session_Key { get; set; }
		public int Circuit_Key { get; set; }
        public string Circuit_Short_Name { get; set; }
        public string Country_Code { get; set; }
        public int Country_Key { get; set; }
        public string Country_Name { get; set; }
        public DateTime Date_End { get; set; }
        public DateTime Date_Start { get; set; }
        public TimeSpan Gmt_Offset { get; set; }
        public string Location { get; set; }
        public int Meeting_Key { get; set; }
        public string Session_Name { get; set; }
        public string Session_Type { get; set; }
        public int Year { get; set; }
    }
}
