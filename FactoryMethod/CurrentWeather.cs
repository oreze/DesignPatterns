using System;

namespace ConsoleApp1.FactoryMethod
{
    public class CurrentWeather: WeatherFactory
    {
        public string GetWeather(string place)
        {
            Console.WriteLine($"Sending request to http://api.openweathermap.org/data/2.5/weather?type=current&q={place}&appid=APIKEY1234562137");
            return "CurrentWeather";
        }
    }
}