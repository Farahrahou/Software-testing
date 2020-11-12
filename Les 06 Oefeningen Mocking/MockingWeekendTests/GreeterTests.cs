using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OefeningMockingWeekend;
using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingWeekend.Tests
{
    [TestClass()]
    public class GreeterTests
    {
        [TestMethod()]
        public void GetMessage_Returns_Right_Message_In_Day_Of_Week()
        {
            //Arrange
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2020, 10, 20));

            //Act
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            var expected = "Work hard, weekend is on his way....";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetMessage_Returns_Right_Message_In_Weekend()
        {
            //Arrange
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2020, 10, 18));

            //Act
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            var expected = "Party time.....it's weekend";

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}