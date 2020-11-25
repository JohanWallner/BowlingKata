using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKataTest
{
    [TestClass]
    public class BowlingKataTest
    {
        private BowlingGame game;

        [TestInitialize]
        public void Initialize()
        {
            game = new BowlingGame();
        }

        [TestMethod]
        public void CanRollGutterGame()
        {
            RollMany(0, 20);
            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void CanRollOnes()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);
            Assert.AreEqual(16, game.Score);
        }
        [TestMethod]
        public void CanRollStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);
            Assert.AreEqual(24, game.Score);
        }
        [TestMethod]
        public void CanRollPerfectGame()
        {
            RollMany(10, 12);
            Assert.AreEqual(300, game.Score);
        }

        private void RollMany(int pins, int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}

