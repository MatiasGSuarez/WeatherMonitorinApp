using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.Model
{
    public class WeatherDataModel
    {
        public string Location { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
    }
}
