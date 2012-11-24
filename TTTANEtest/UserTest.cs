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
    }
}
