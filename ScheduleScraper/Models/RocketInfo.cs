using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleScraper.Models
{
    public class RocketInfo
    {
        public string Model { get; set; }

        public RocketInfo(string model)
        {
            Model = model;
        }
    }
}
