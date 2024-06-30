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
        private int v1;
        private string v2;

        public RainBot(double humidityThreshold, double temperatureThreshold, string message)
        {
            HumidityThreshold = humidityThreshold;
            Message = message;
            
        }

        public double HumidityThreshold { get; set; }
        public double TemperatureThreshold { get; set; }
        public string Message { get; set; }


 
        public void Update(double temperature, double humidity)
        {
            Console.WriteLine("Rain bot updated.");
        }

    }
}
