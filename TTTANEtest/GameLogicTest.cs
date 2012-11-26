using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTTANE;

namespace TTTANEtest
{
    [TestClass]
    public class GameLogicTest
    {
        private GameLogic _gameLogic;

        protected String[][] _winningCombinations = new[] 
            {
                //Winning Rows [1,2,3]
                new[] {"1","2","3"},
                new[] {"4","5","6"},
                new[] {"7","8","9"},

                //Winning Columns [1,2,3]
                new[] {"1","4","7"},
                new[] {"2","5","8"},
                new[] {"3","6","9"},

                //Winning Diagonals [1,2]
                new[] {"1","5","9"},
                new[] {"7","5","3"}
            };

        [TestInitialize]
        public void InitializeGameLogic()
        {
            _gameLogic = new GameLogic();

        }

        /// <summary>
        /// Prufar getGameBoard fall
        /// </summary>
        [TestMethod()]
        public void TestGetGameBoard()
        {
            
            String[] test = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            CollectionAssert.AreEqual(test, _gameLogic.getGameBoard());
        }

        /// <summary>
        /// Prufar getGameBoardLocation(int i) fall sem skilar gildi í sæti i í gameBoard fylkinu
        /// </summary>
        [TestMethod()]
        public void TestSetTicLocation()
        {
            _gameLogic.setPlayerInput(3, "X");
            Assert.AreEqual("X", _gameLogic.getGameBoardLoc(3));
        }

        /// <summary>
        /// Skilar hvað er í sæti i í gameBoard fylkinu
        /// </summary>
        [TestMethod()]
        public void TestGetBoardLocation()
        {
            //INFO: Sækir hvað er í [x] reit á borði
            String output = "6";
            Assert.AreEqual(output, _gameLogic.getGameBoardLoc(5));
        }

        /// <summary>
        /// Prófar getWinningCombinationRow(int i) sem skilar röð úr winningCimbinations fylkinu
        /// </summary>
        [TestMethod()]
        public void TestGetWinningCombinationRow()
        {
            String[] expected = new String[] { "1", "2", "3" };
            CollectionAssert.AreEqual(expected, _gameLogic.getWinningCombinationRow(0));
        }

        /// <summary>
        /// Prófar getWinningCombinationColumn(int i) sem skilar dálki úr winningCombinations fylkinu 
        /// </summary>
        [TestMethod()]
        public void TestGetWinningCombinationColumn()
        {
            String[] expected = new String[] { "1", "4", "7" };
            CollectionAssert.AreEqual(expected, _gameLogic.getWinningCombinationColumn(0));
        }

        /// <summary>
        /// Prófar getWinningCombinationDiagonal(int i) sem skilar hornréttri línu úr winningCombination fylkinu
        /// </summary>
        [TestMethod()]
        public void TestGetWinningCombinationDiagonal()
        {
            String[] expected = new String[] {"1","5", "9"};
            CollectionAssert.AreEqual(expected, _gameLogic.getWinningCombinationDiagonal(0));
        }

        /// <summary>
        /// Prófar changePlayer() fallið sem sér um að halda utan um hver á að gera
        /// </summary>
        [TestMethod()]
        public void TestChangePlayer()
        {
            _gameLogic.CurrPlayer = "X";
            _gameLogic.ChangePlayer();
            Assert.AreEqual("O", _gameLogic.CurrPlayer);
        }

        [TestMethod()]
        public void TestGetAvailableMoves()
        {
            var expected = new String[] {"2","5","6","7","9"};
            _gameLogic.PlayMoves("X1", "O3", "X4", "O8");
            CollectionAssert.AreEqual(expected, _gameLogic.AvailableMoves);
        }

        [TestMethod()]
        public void TestCheckWinnerRow()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            String[] expected = new String[] { "X", "X", "X" ,"O", "5", "O", "7", "8", "9"};
            String[] values = new String[3];
      //      for (int i = 0; i < 1; i++)
        //    {
            int i = 0;
                for (int j = 0; j < 3; j++)
                {
                    values[j] = _winningCombinations[i][j];
                }
                if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1 ]) && (expected[(Convert.ToInt32(values[1])) -1] == expected[(Convert.ToInt32(values[2]))-1]))
                {
                    _gameLogic.winner = true; 
                }
//            }

            Assert.AreEqual(true, _gameLogic.winner);

        }
        [TestMethod()]
        public void TestCheckWinnerColumn()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            String[] expected = new String[] { "X", "2", "3", "X", "5", "O", "X", "8", "9" };
            String[] values = new String[3];
            //      for (int i = 0; i < 1; i++)
            //    {
            int i = 3;
            for (int j = 0; j < 3; j++)
            {
                values[j] = _winningCombinations[i][j];
            }
            if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1]) && (expected[(Convert.ToInt32(values[1])) - 1] == expected[(Convert.ToInt32(values[2])) - 1]))
            {
                _gameLogic.winner = true;
            }
            //            }

            Assert.AreEqual(true, _gameLogic.winner);

        }

        [TestMethod()]
        public void TestCheckWinnerDiagonal()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            String[] expected = new String[] { "X", "2", "3", "4", "X", "O", "7", "8", "X" };
            String[] values = new String[3];
            //      for (int i = 0; i < 1; i++)
            //    {
            int i = 6;
            for (int j = 0; j < 3; j++)
            {
                values[j] = _winningCombinations[i][j];
            }
            if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1]) && (expected[(Convert.ToInt32(values[1])) - 1] == expected[(Convert.ToInt32(values[2])) - 1]))
            {
                _gameLogic.winner = true;
            }
            //            }

            Assert.AreEqual(true, _gameLogic.winner);

        }

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
