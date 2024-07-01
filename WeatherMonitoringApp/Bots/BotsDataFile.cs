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
        private readonly IBotListener _botSystem;

        private readonly List<IBot> _bots = [];

        public BotsDataFile(IBotListener botSystem)
        {
            _botSystem = botSystem;
        }

        //Aca harcodee los parametros para que se activen los bots
        public void CreateAndLoadBots()
        {
            var rainbot = new RainBot(70, "It looks like it's about to pour down!");
            _bots.Add(rainbot);

            var sunbot = new SunBot(40, "Wow, it's a scorcher out there!");
            _bots.Add(sunbot);

            var snowbot = new SnowBot(0, "Brrr, it's getting chilly!");
            _bots.Add(snowbot);

            foreach (var bot in _bots)
            {
                _botSystem.Subscribe(bot);
            }
        }
    }
}
