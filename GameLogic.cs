using System;

namespace TTTANE
{
    public class GameLogic
    {
        #region Member breytur
        //Frumstillir borðið
        public String[] GameBoard = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //Mögulegar sigurleiðir
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
        //Frumstilli Currplayer
        public virtual string CurrPlayer { get; set; }

        public bool Winner { get; set; }
        #endregion

        

        public String[] GetGameBoard()
        {
            return GameBoard;
        }

        public String GetGameBoardLoc(int input)
        {
            return GameBoard[input];
        }

        public bool SetPlayerInput(int i, String x) 
        {
            if (x.Equals(GameBoard[i]))
            {
                throw new InvalidMoveException("Nú þegar er : '{0}' í þessum reit, vinsamlega gerðu aftur", GameBoard[i] );
            }
            GameBoard[i] = x;
            return true;
        }

        /// <summary>
        /// Skilar Röð úr WinningCombination[][]
        /// </summary>
        /// <param name="i">i er númer raðar</param>
        /// <returns>
        /// Streng sem er 3 á lengd og inniheldur röð úr WinningCombination[][]
        /// </returns>
        public String[] GetWinningCombinationRow(int i)
        {
            var output = new String[3];
            for (var j = 0; j < 3; j++)
            {
                output.SetValue(WinningCombinations[i][j], j);
            }

            return output;
         }

        /// <summary>
        /// Skilar dálk úr WinningCombination[][]
        /// </summary>
        /// <param name="i">i er númer dálks</param>
        /// <returns>
        /// Streng sem er 3 á lengd og inniheldur dálk úr WinningCombination[][]
        /// </returns>
        public String[] GetWinningCombinationColumn(int i)
        {
            i = i + 3;
            var output = new String[3];
            for (var j = 0; j < 3; j++)
            {
                output.SetValue(WinningCombinations[i][j], j);
            }

            return output;
        }

        /// <summary>
        /// Skilar hornréttri línu úr WinningCombination[][]
        /// </summary>
        /// <param name="i">i er númer hornréttrar línu ( 1 = 1,5,9 og 2 = 3,5,7 )</param>
        /// <returns>
        /// Streng sem er 3 á lengd og inniheldur diagonal úr WinningCombination[][]
        /// </returns>
        public String[] GetWinningCombinationDiagonal(int i)
        {
            i = i + 6;
            var output = new String[3];
            for (int j = 0; j < 3; j++)
            {
                output.SetValue(WinningCombinations[i][j], j);
            }
            return output;
        }

        /// <summary>
        /// Teiknar borðið, fyllir út í reiti eftir gameBoard[] sem er fylki sem geymir hvað er búið og hvað er eftir.
        /// </summary>
        public void DrawBoard()
        {
            int k = 0;
            for (int l = 0; l < 4; l++)
            {
                Console.Write("- ");
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(GameBoard[k] + "|");
                    k++;
                }
                Console.Write("\n");
            }
            Console.ResetColor();
            for (int l = 0; l < 4; l++)
            {
                Console.Write("- ");
            }
            Console.Write("\n");
            
        }
        /// <summary>
        /// Skipti player úr X í O eða O í X eftir atvikum.
        /// </summary>
        public void ChangePlayer()
        {
            CurrPlayer = (CurrPlayer == "X" ? "O" : "X");
        }

        /// <summary>
        /// Method til að athuga hvort kominn sé sigurvegari. Keyrir í gegnum winningCombinations[][] og athugar allar mögulegar útfærslur
        /// </summary>
        public bool CheckWinner()
        {
            var values = new String[3];
            for (var i = 0; i < 9 ; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    values[j] = WinningCombinations[i][j];
                }
                if ((GameBoard[(Convert.ToInt32(values[0])) - 1] != GameBoard[(Convert.ToInt32(values[1])) - 1]) ||
                    (GameBoard[(Convert.ToInt32(values[1])) - 1] != GameBoard[(Convert.ToInt32(values[2])) - 1]))
                    continue;
                Winner = true;
                return Winner;
            }
            return false;
        }
    }
}
