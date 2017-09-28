using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleScraper.Models
{
    public class MissionInfo
    {
        public string Description { get; set; }
        public string PayloadName { get; set; }
        public DateTime? LaunchDate { get; set; }
        

        public MissionInfo(string description, string payloadName, DateTime? launchDate = null)
        {
            Description = description;
            PayloadName = payloadName;
            LaunchDate = launchDate;
        }
    }
}
