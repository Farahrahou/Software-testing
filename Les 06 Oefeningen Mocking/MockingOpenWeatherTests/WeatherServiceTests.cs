using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OefeningMockingOpenWeather;
using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingOpenWeather.Tests
{
    [TestClass()]
    public class WeatherServiceTests
    {
        [TestMethod()]
        public void GetCurrentTemperatureInAntwerp_Returns_Right_Text_If_Temp_Beneath_0()
        {
            //Arrange
            var weatherApi = new Mock<IOpenWeatherMapApi>();
            weatherApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(-1);

            //Act
            var weatherService = new WeatherService(weatherApi.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            var expected = "Brrrr, it's freezing";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetCurrentTemperatureInAntwerp_Returns_Right_Text_If_Temp_Beneath_15()
        {
            //Arrange
            var weatherApi = new Mock<IOpenWeatherMapApi>();
            weatherApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(10);

            //Act
            var weatherService = new WeatherService(weatherApi.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            var expected = "It's cold";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetCurrentTemperatureInAntwerp_Returns_Right_Text_If_Temp_Beneath_24()
        {
            //Arrange
            var weatherApi = new Mock<IOpenWeatherMapApi>();
            weatherApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(20);

            //Act
            var weatherService = new WeatherService(weatherApi.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            var expected = "it's ok";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetCurrentTemperatureInAntwerp_Returns_Right_Text_If_Temp_Above_24()
        {
            //Arrange
            var weatherApi = new Mock<IOpenWeatherMapApi>();
            weatherApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(25);

            //Act
            var weatherService = new WeatherService(weatherApi.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            var expected = "It's HOT!!!";

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}