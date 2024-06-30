using System.Runtime.CompilerServices;
using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Interfaces;



var botSystem = new BotSystem();
var newinst = new BotsDataFile(botSystem);
newinst.CreateAndLoadBots(); 