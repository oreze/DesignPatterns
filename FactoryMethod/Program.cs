using System;

namespace ConsoleApp1.FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            WeeklyWeather Weekly = new WeeklyWeather();
            CurrentWeather Current = new CurrentWeather();
            WeatherController Controller = new WeatherController();
            Console.WriteLine(Controller.GetWeather(Weekly, "London"));
            Console.WriteLine(Controller.GetWeather(Current, "London"));
        }
    }
}