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
        public string Cargo { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public ScheduleModel(string rocketModel, string cargo, string date, string location, string description)
        {
            RocketModel = rocketModel;
            Cargo = cargo;
            Date = date;
            Location = location;
            Description = description;
        }
    }
}
