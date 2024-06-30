using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Interfaces
{
    public interface IWeatherDataParser
    {
        bool TryParse(string text, out WeatherDataModel? weatherData);

    }
}
