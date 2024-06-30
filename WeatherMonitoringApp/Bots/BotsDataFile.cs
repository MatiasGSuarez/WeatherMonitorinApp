using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.Interfaces;

namespace WeatherMonitoringApp.Bots
{
    public class BotsDataFile
    {
        private readonly BotSystem _botSystem;

        private readonly List<IBot> _bots = [];

        public BotsDataFile(BotSystem botSystem)
        {
            _botSystem = botSystem;
        }

        public void CreateAndLoadBots()
        {
            var rainbot = new RainBot(98, 35, "etc");
            _bots.Add(rainbot);
            foreach (var bot in _bots)
            {
                _botSystem.Subscribe(bot);
            }
        }
    }
}
