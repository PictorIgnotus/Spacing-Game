using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpacingGame.Model;
using SpacingGame;

namespace SGTest
{
    [TestClass]
    public class UnitTest1
    {
        #region SpaceshipTest 
        [TestMethod]
        public void SpaceShipTest()
        {
            Spaceship spaceship = new Spaceship(5);
            Assert.AreEqual(5, spaceship.XKOORDINATE);
        }

        [TestMethod]
        public void SpaceShipMoveLeftTest()
        {
            Spaceship spaceship = new Spaceship(5);
            spaceship.MoveTo(Direction.Left);
            Assert.AreEqual(4, spaceship.XKOORDINATE);
        }

        [TestMethod]
        public void SpaceShipMoveRightTest()
        {
            Spaceship spaceship = new Spaceship(5);
            spaceship.MoveTo(Direction.Right);
            Assert.AreEqual(6, spaceship.XKOORDINATE);
        }
        #endregion

        #region AsteroidTest

        Asteroid asteroid = new Asteroid(10);
        [TestMethod]
        public void AsteroidTest()
        {
            Assert.AreEqual(new Tuple<int, int>(10, 0), asteroid.KOORDINATES);
        }
        
        #endregion
    }
}
