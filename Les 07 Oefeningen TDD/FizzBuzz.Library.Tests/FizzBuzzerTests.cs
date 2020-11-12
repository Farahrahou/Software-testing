using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)]int input)
        {
            // Arrange
            // --> input wordt geregeld via argument, om herhaling te vermijden 
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6, 9, 12, 18)]int input)
        {
            // Arrange
            // --> input wordt geregeld via argument, om herhaling te vermijden 
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz([Values(5, 10, 20)]int input)
        {
            // Arrange
            // --> input wordt geregeld via argument, om herhaling te vermijden 
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15)] int input)
        {
            // Arrange
            // --> input wordt geregeld via argument, om herhaling te vermijden 
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
