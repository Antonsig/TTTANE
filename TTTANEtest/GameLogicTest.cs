using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTTANE;

namespace TTTANEtest
{
    [TestClass]
    public class GameLogicTest
    {
        private GameLogic _gameLogic;
        [TestInitialize]
        public void InitializeGameLogic()
        {
            _gameLogic = new GameLogic();
        }


        [TestMethod()]
        public void TestSetMove()
        {
            //TODO : Set X eða O á réttan stað í borði
             //Frumstillir nýjan notanda með 'X'
            User user1 = new User("X");
            //Þá er user2 default gildi 'O'
            User user2 = new User("O"); 
 
            _gameLogic.setGameBoard(3) = "X";
            Assert.AreEqual("X", _gameLogic.getGameBoardLoc(3));
            String[] test = new String[] { "1", "2", "3", "X", "5", "6", "7", "8", "9"};
            Assert.AreEqual(test, _gameLogic.getGameBoard());
        }

        [TestMethod()]
        public String TestGetBoardLocation()
        {
            //INFO: Sækir hvað er í [x] reit á borði
            String output = null;
            return output;
        }

        [TestMethod()]

        /*
       
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
         * */

        
    }
}
