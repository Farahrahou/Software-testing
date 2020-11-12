using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingOpenWeather
{
    public class WeatherService
    {
        private readonly IOpenWeatherMapApi _openWeatherMapApi;

        public WeatherService(IOpenWeatherMapApi openWeatherMapApi)
        {
            _openWeatherMapApi = openWeatherMapApi;
        }

        public string GetCurrentWeatherInAntwerp()
        {
            var temp = _openWeatherMapApi.GetCurrentTemperatureInAntwerp();
            // writing temperature to console (testing purposes)
            Console.WriteLine($"Temperature is {temp}");
            if (temp < 0)
            {
                return "Brrrr, it's freezing";
            }
            if (temp < 15)
            {
                return "It's cold";
            }
            if (temp < 24)
            {
                return "it's ok";
            }
            return "It's HOT!!!";
        }
    }
}