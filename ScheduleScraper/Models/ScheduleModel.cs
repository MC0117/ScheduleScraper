using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleScraper.Models
{
    public class ScheduleModel
    {
        public string RocketModel { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        public ScheduleModel(string rocketModel, string date, string location)
        {
            RocketModel = rocketModel;
            Date = date;
            Location = location;
        }
    }
}
