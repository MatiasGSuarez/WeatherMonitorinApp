using System.Runtime.CompilerServices;
using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Interfaces;
using WeatherMonitoringApp.Model;



IBotListener botSystem = new Bot();
var newinst = new BotsDataFile(botSystem);
EnterDataWeather entry = new EnterDataWeather(botSystem);

//Create the bots
newinst.CreateAndLoadBots();
do
{
    
    entry.DataEntry();
}
while (true);

string paraesperarnomas = Console.ReadLine();
