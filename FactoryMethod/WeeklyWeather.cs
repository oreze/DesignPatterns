using System;

namespace ConsoleApp1.FactoryMethod
{
    public class WeeklyWeather: WeatherFactory
    {
        public string GetWeather(string place)
        {
            Console.WriteLine($"Sending request to http://api.openweathermap.org/data/2.5/weather?type=weekly&q={place}&appid=APIKEY1234562137");
            return "WeeklyWeather";
        }

    }
}