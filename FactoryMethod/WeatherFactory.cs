using System;

namespace ConsoleApp1.FactoryMethod
{
    public interface WeatherFactory
    {
        public string GetWeather(string place);
    }
}