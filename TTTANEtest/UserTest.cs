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
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            Assert.AreEqual("Player1", User1.userName);
            Assert.AreEqual("Player2", User2.userName);
        }

        /// <summary>
        /// Test fyrir smiðinn í User klasanum ef sendur er inn tómur strengur.
        ///</summary>
        [TestMethod()]
        public void TestUserNoNameReturned()
        {
            User User1 = new User("");
            User User2 = new User("");

            Assert.AreEqual("Player", User1.userName);
            Assert.AreEqual("Player", User2.userName);
        }

        /// <summary>
        /// Test fyrir resetMoves fallið sem 0stillir öll moves.
        ///</summary>
        [TestMethod()]
        public void TestUserMovesArrayReset()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            User1.setMove(2, 2);
            User1.resetMoves();

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
        /// Test sem athugar hvort parsing fallið hleypir í gegn löglegum gildum
        /// og returnar false ef svo er ekki.
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

            Assert.IsTrue(User1.parseInput(move1));
            Assert.IsTrue(User2.parseInput(move2));
            Assert.IsFalse(User1.parseInput(move3));
            Assert.IsFalse(User2.parseInput(move4));
            Assert.IsFalse(User1.parseInput(move5));
        }

        /// <summary>
        /// Test sem athugar hvort isWinner returnar true á vinningsröð
        /// of false ef svo er ekki.
        ///</summary>
        [TestMethod()]
        public void TestUserIsWinner()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            User1.setMove(0, 0);
            User2.setMove(1, 1);
            User1.setMove(0, 1);
            User2.setMove(2, 2);
            User1.setMove(0, 2);

            Assert.IsTrue(User1.isWinner());
            Assert.IsFalse(User2.isWinner());
        }

        /// <summary>
        /// Test sem athugar hvort leikur hefur þegar verið leikinn.
        /// parseinput skilar false ef svo er en true ef svo er ekki.
        ///</summary>
        [TestMethod()]
        public void UserTestIfMoveHasBeenMade()
        {
            User User1 = new User("Player1");
            User User2 = new User("Player2");

            Assert.IsTrue(User1.parseInput("A3"));
            Assert.IsTrue(User2.parseInput("B2"));
            Assert.IsFalse(User1.parseInput("A3"));
        }
    }
}
