using System;

namespace OefeningMockingOpenWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new WeatherService(new OpenWeatherMapApi());
            Console.WriteLine(weather.GetCurrentWeatherInAntwerp());

            Console.ReadKey();
        }
    }
}
