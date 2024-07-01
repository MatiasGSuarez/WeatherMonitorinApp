using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Data_Parser
{
    public class JsonDataParser : IWeatherDataParser
    {
        public bool TryParse(string text, out WeatherDataModel? weatherData)
        {
            try
            {
                weatherData = JsonSerializer.Deserialize<WeatherDataModel>(text);
                if (weatherData is null || string.IsNullOrWhiteSpace(weatherData.Location))
                    return false;
                return true;
            }
            catch
            {
                weatherData = null;
                return false;
            };
        }
    }
}
