using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Data_Parser;
using WeatherMonitoringApp.Interfaces;

namespace WeatherMonitoringApp.Model
{
    public class EnterDataWeather
    {
        private JsonDataParser jsonparser = new JsonDataParser();
        private XmlDataParser xmlparser = new XmlDataParser();
        private IBotListener ibotlistener;

        public EnterDataWeather(IBotListener _ibotlistener) 
        {
            ibotlistener = _ibotlistener;
        }

        public void DataEntry()
        {
            WeatherDataModel weatherDataModel = null;

            while (weatherDataModel == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the data in JSON or XML format:");
                string input = Console.ReadLine().Trim();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please try again.");
                    continue;
                }

                if (jsonparser.TryParse(input, out WeatherDataModel jsonData))
                {
                    weatherDataModel = jsonData;
                }
                else if (xmlparser.TryParse(input, out WeatherDataModel xmlData))
                {
                    weatherDataModel = xmlData;
                }
                else
                {
                    Console.WriteLine("Imposible to determine the format");
                }
            }

            ibotlistener.Notify(weatherDataModel);
        }
    }
}
