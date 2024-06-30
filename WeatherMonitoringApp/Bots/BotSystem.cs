using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;

namespace WeatherMonitoringApp.Bots
{
    public class BotSystem
    {
        private readonly List<IBot> botListners = [];

        public BotSystem()
        {
        }

        public List<IBot> GetBotListners()
        {
            return botListners;
        }
        public void Subscribe(IBot botListner)
        {
            botListners.Add(botListner);
        }

        public void Notify(WeatherDataModel weatherData)
        {
            botListners.ForEach((bot) => bot.Update(weatherData.Temperature, weatherData.HumidityLevel));
        }
    }
}
