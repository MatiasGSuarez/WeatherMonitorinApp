using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Interfaces
{
    public interface IBot
    {
        public decimal HumidityThreshold { get; set; }
        public decimal TemperatureThreshold { get; set; }
        public string Message { get; set; }
        public void Update(decimal temperature, decimal humidity);
    }

    public interface IBotListener
    {
        void Notify(WeatherDataModel weatherData);
        void Subscribe(IBot botListener);
    }
}
