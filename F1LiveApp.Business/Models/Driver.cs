using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Business.Models
{
	public class Driver
	{
        [Key]
		public int Driver_Number { get; set; }
		public string Broadcast_Name { get; set; }
        public string Country_Code { get; set; }
        public string First_Name { get; set; }
        public string Full_Name { get; set; }
        public string Headshot_Url { get; set; }
        public string Last_Name { get; set; }
        public int Meeting_Key { get; set; }
        public Meeting Meeting { get; set; }
        public string Name_Acronym { get; set; }
        public int Session_Key { get; set; }
        public Session Session { get; set; }
        public string Team_Colour { get; set; }
        public string Team_Name { get; set; }
    }
}
