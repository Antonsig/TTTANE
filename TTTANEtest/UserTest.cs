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
        ///A test for User constructor resetting all moves to zero
        ///</summary>
        [TestMethod()]
        public void TestUserMovesArrayReset()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(User1.moves[i, j], 0);
                    Assert.AreEqual(User2.moves[i, j], 0);
                }
            }
        }

        /// <summary>
        ///This test checks the parsing of the input string.
        ///</summary>
        [TestMethod()]
        public void TestUserParseInput()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            string move1 = "A1";
            string move2 = "c2";
            string move3 = "L2";
            string move4 = "C54";
            string move5 = "";

            Assert.IsTrue(User1.parseinput(move1));
            Assert.IsTrue(User2.parseinput(move2));
            Assert.IsFalse(User1.parseinput(move3));
            Assert.IsFalse(User2.parseinput(move4));
            Assert.IsFalse(User1.parseinput(move5));
        }

        /// <summary>
        ///This test checks if there is a winning row.
        ///</summary>
        [TestMethod()]
        public void TestUserIsWinner()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            User1.savemove(0, 0);
            User2.savemove(1, 1);
            User1.savemove(0, 1);
            User2.savemove(2, 2);
            User1.savemove(0, 2);

            Assert.IsTrue(User1.iswinner());
            Assert.IsFalse(User2.iswinner());
        }

        /// <summary>
        ///This test checks if the move has aldready been made
        ///</summary>
        [TestMethod()]
        public void UserTestIfMoveHasBeenMade()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            Assert.IsTrue(User1.parseinput("A3"));
            Assert.IsTrue(User2.parseinput("B2"));
            Assert.IsFalse(User1.parseinput("A3"));
        }
    }
}
