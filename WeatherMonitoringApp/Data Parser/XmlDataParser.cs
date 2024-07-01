using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Data_Parser
{
    public class XmlDataParser : IWeatherDataParser
    {
        public bool TryParse(string text, out WeatherDataModel? weatherData)
        {
            weatherData = null;
            try
            {
                XDocument xdoc = XDocument.Parse(text);
                var xmlWeathersData = xdoc.Element("WeatherData");
                if (!ValidateXMLData(xdoc)) return false;
                weatherData = new WeatherDataModel()
                {
                    Location = xmlWeathersData!.Element("Location")!.Value,
                    Humidity = decimal.Parse(xmlWeathersData!.Element("Temperature")!.Value),
                    Temperature = decimal.Parse(xmlWeathersData!.Element("Humidity")!.Value)
                };
                return true;
            }
            catch
            {
                return false;
            }
        }
        private static bool ValidateXMLData(XDocument xdoc)
        {
            var xLoaction = xdoc.Element("WeatherData")?.Element("Location")?.Value;
            var xTemperature = xdoc.Element("WeatherData")?.Element("Temperature")?.Value;
            var xHumidity = xdoc.Element("WeatherData")?.Element("Humidity")?.Value;
            return !string.IsNullOrWhiteSpace(xLoaction) &&
                   !string.IsNullOrWhiteSpace(xTemperature) &&
                   !string.IsNullOrWhiteSpace(xHumidity);
        }
    }
}
