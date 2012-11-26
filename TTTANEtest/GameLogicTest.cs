using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTTANE;

namespace TTTANEtest
{
    [TestClass]
    public class GameLogicTest
    {
        private GameLogic _gameLogic;

        protected String[][] WinningCombinations = new[] 
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
        [TestMethod]
        public void TestGetGameBoard()
        {           
            var test = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            CollectionAssert.AreEqual(test, _gameLogic.GetGameBoard());
        }

        /// <summary>
        /// Prufar getGameBoardLocation(int i) fall sem skilar gildi í sæti i í gameBoard fylkinu
        /// </summary>
        [TestMethod]
        public void TestSetTicLocation()
        {
            _gameLogic.SetPlayerInput(3, "X");
            Assert.AreEqual("X", _gameLogic.GetGameBoardLoc(3));
        }

        /// <summary>
        /// Skilar hvað er í sæti i í gameBoard fylkinu
        /// </summary>
        [TestMethod]
        public void TestGetBoardLocation()
        {
            //INFO: Sækir hvað er í [x] reit á borði
            const string output = "6";
            Assert.AreEqual(output, _gameLogic.GetGameBoardLoc(5));
        }

        /// <summary>
        /// Prófar getWinningCombinationRow(int i) sem skilar röð úr winningCimbinations fylkinu
        /// </summary>
        [TestMethod]
        public void TestGetWinningCombinationRow()
        {
            var expected = new[] { "1", "2", "3" };
            CollectionAssert.AreEqual(expected, _gameLogic.GetWinningCombinationRow(0));
        }

        /// <summary>
        /// Prófar getWinningCombinationColumn(int i) sem skilar dálki úr winningCombinations fylkinu 
        /// </summary>
        [TestMethod]
        public void TestGetWinningCombinationColumn()
        {
            var expected = new[] { "1", "4", "7" };
            CollectionAssert.AreEqual(expected, _gameLogic.GetWinningCombinationColumn(0));
        }

        /// <summary>
        /// Prófar getWinningCombinationDiagonal(int i) sem skilar hornréttri línu úr winningCombination fylkinu
        /// </summary>
        [TestMethod]
        public void TestGetWinningCombinationDiagonal()
        {
            var expected = new[] {"1","5", "9"};
            CollectionAssert.AreEqual(expected, _gameLogic.GetWinningCombinationDiagonal(0));
        }

        /// <summary>
        /// Prófar changePlayer() fallið sem sér um að halda utan um hver á að gera
        /// </summary>
        [TestMethod]
        public void TestChangePlayer()
        {
            _gameLogic.CurrPlayer = "X";
            _gameLogic.ChangePlayer();
            Assert.AreEqual("O", _gameLogic.CurrPlayer);
        }

        [TestMethod]
        public void TestCheckWinnerRow()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            var expected = new[] { "X", "X", "X" ,"O", "5", "O", "7", "8", "9"};
            var values = new string[3];
            var i = 0;

            for (var j = 0; j < 3; j++)
            {
                values[j] = WinningCombinations[i][j];
            }
            
			if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1 ]) && (expected[(Convert.ToInt32(values[1])) -1] == expected[(Convert.ToInt32(values[2]))-1]))
            {
                _gameLogic.Winner = true; 
            }
            
			Assert.AreEqual(true, _gameLogic.Winner);
        }
       
		[TestMethod]
        public void TestCheckWinnerColumn()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            var expected = new[] { "X", "2", "3", "X", "5", "O", "X", "8", "9" };
            var values = new String[3];
            var i = 3;
            
			for (var j = 0; j < 3; j++)
            {
                values[j] = WinningCombinations[i][j];
            }
           
			if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1]) && (expected[(Convert.ToInt32(values[1])) - 1] == expected[(Convert.ToInt32(values[2])) - 1]))
            {
                _gameLogic.Winner = true;
            }

            Assert.AreEqual(true, _gameLogic.Winner);
        }

        [TestMethod]
        public void TestCheckWinnerDiagonal()
        {
            _gameLogic.CurrPlayer = "X";
            //Gameboard
            var expected = new[] { "X", "2", "3", "4", "X", "O", "7", "8", "X" };
            var values = new String[3];
            var i = 6;
            
			for (var j = 0; j < 3; j++)
            {
                values[j] = WinningCombinations[i][j];
            }
            
			if ((expected[(Convert.ToInt32(values[0])) - 1] == expected[(Convert.ToInt32(values[1])) - 1]) && (expected[(Convert.ToInt32(values[1])) - 1] == expected[(Convert.ToInt32(values[2])) - 1]))
            {
                _gameLogic.Winner = true;
            }

            Assert.AreEqual(true, _gameLogic.Winner);
        }
    }   
}
