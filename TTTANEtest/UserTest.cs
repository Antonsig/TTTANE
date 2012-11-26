using System;
using TTTANE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTTANEtest
{
    /// <summary>
    /// Testklasi fyrir User klasann og á að innihalda
    /// öll þau unit test sem gerð verða fyrir þann klasa.
    ///</summary>

    [TestClass()]
    public class UserTest
    {
        /// <summary>
        /// Test fyrir smiðinn í User klasanum
        /// Ætti að senda til baka sama streng og sett var í smiðinn.
        ///</summary>
        [TestMethod()]
        public void TestUserNameReturned()
        {
            User User1 = new User("Player1","X");
            User User2 = new User("Player2", "O");

            Assert.AreEqual("Player1", User1.UserName);
            Assert.AreEqual("Player2", User2.UserName);
        }

        /// <summary>
        /// Test fyrir smiðinn í User klasanum ef sendur er inn tómur strengur.
        ///</summary>
        [TestMethod()]
        public void TestUserNoNameReturned()
        {
            User User1 = new User("", "X");
            User User2 = new User("", "O");

            Assert.AreEqual("Player", User1.UserName);
            Assert.AreEqual("Player", User2.UserName);
        }

    }
}
