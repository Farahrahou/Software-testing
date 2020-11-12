using NUnit.Framework;

namespace BowlingGameScoreTests
{
    public class Tests
    {
        private BowlingGame game;

        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {
            // Arrange
            // --> er wordt steeds nieuwe game instantie aangemaakt voor elke test door SetUp
            // Act
            RollMany(20, 0);
            // Assert
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void When_Roll_AllOnes_Returns_20()
        {
            // Arrange
            // --> er wordt steeds nieuwe game instantie aangemaakt voor elke test door SetUp
            // Act
            RollMany(20, 1);
            // Assert
            Assert.AreEqual(20, game.Score);
        }

        [Test]
        public void When_Roll_SpareAndThree_Returns_16()
        {
            // Act
            RollMany(2, 5);
            RollMany(1, 3);
            //Assert
            Assert.AreEqual(16, game.Score);
        }

        [Test]
        public void When_Roll_SpareAndSeven_Returns_24()
        {
            // Act
            RollMany(1, 10);
            RollMany(1, 3);
            RollMany(1, 4);
            //Assert
            Assert.AreEqual(24, game.Score);
        }

        [Test]
        public void When_Roll_PerfectGame_Returns_300()
        {
            // Act
            RollMany(12, 10);
            //Assert
            Assert.AreEqual(300, game.Score);
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

    }
}