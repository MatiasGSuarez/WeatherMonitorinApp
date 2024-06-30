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
        public double HumidityThreshold { get; set; }
        public double TemperatureThreshold { get; set; }
        public string Message { get; set; }


        public void Update(double temperature, double humidity)
        {
            Console.WriteLine("Snow bot updated.");
        }
    }
}
