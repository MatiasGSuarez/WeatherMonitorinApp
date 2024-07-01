using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Bots
{
    public class SnowBot : IBot
    {
        public SnowBot(decimal temperatureThreshold, string message)
        {
            TemperatureThreshold = temperatureThreshold;
            Message = message;
        }

        public decimal HumidityThreshold { get; set; }
        public decimal TemperatureThreshold { get; set; }
        public string Message { get; set; }


        public void Update(decimal temperature, decimal humidity)
        {
            if (temperature < HumidityThreshold)
            {
                Console.WriteLine("SnowBot Activated.");
                Console.WriteLine($"SnowBot: {Message}");
            }
        }
    }
}
