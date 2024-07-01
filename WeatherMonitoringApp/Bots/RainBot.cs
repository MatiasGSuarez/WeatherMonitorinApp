using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Bots
{
    public class RainBot : IBot
    {
        public RainBot(decimal humidityThreshold, string message)
        {
            HumidityThreshold = humidityThreshold;
            Message = message;
        }

        public decimal HumidityThreshold { get; set; }
        public decimal TemperatureThreshold { get; set; }
        public string Message { get; set; }


        public void Update(decimal temperature, decimal humidity)
        {
            if (humidity >= HumidityThreshold)
            {
                Console.WriteLine("RainBot Activated.");
                Console.WriteLine($"RainBot: {Message}");
            }
        }
    }
}
