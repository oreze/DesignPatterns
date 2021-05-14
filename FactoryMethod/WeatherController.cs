using System.Text.Json;

namespace ConsoleApp1.FactoryMethod
{
    public class WeatherController
    {
        public string GetWeather(WeatherFactory weatherType, string place)
        {
            return weatherType.GetWeather(place);
        }
    }
}