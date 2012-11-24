using System;
using TTTANE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTTANEtest
{
    /// <summary>
    ///This is a test class for User and is intended
    ///to contain all UserTest Unit Tests
    ///</summary>
    
    [TestClass()]
    public class UserTest
    {
        /// <summary>
        ///A test for User Constructor
        ///Should return the name of the constructors string parameter.
        ///</summary>
        [TestMethod()]
        public void TestUserNameReturned()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            Assert.AreEqual("Player1", User1.name);
            Assert.AreEqual("Player2", User2.name);
        }
        /// <summary>
        ///A test for User constructore setting empty input to "Player"
        ///</summary>
        [TestMethod()]
        public void TestUserNoNameReturned()
        {
            User User1 = new User("");
            User User2 = new User("");

            Assert.AreEqual("Player", User1.name);
            Assert.AreEqual("Player", User2.name);
        }

        /// <summary>
        ///A test for User constructore resetting all moves to zero
        ///</summary>
        [TestMethod()]
        public void TestArrayReset()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(User1.moves[i, j], 0);
                    Assert.AreEqual(User2.moves[i, j], 0);
                }
            }
        }


    }
}
