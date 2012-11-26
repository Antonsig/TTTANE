using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
    public class GameLogic
    {
        #region Member breytur
        //Frumstillir borðið
        private String[] gameBoard = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //Mögulegar sigurleiðir
        protected String[][] winningCombinations = new[] 
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

        public bool winner { get; set; }
        #endregion

        

        public String[] getGameBoard()
        {
            return gameBoard;
        }

        public String getGameBoardLoc(int input)
        {
            return gameBoard[input];
        }

        public bool setPlayerInput(int i, String x) 
        {
            bool result = false;
            if (gameBoard[i].Equals(x))
            {
                throw new InvalidMoveException("Nú þegar er : '{0}' í þessum reit, vinsamlega gerðu aftur", gameBoard[i] );
            }
            else
            {
                gameBoard[i] = x;
                result =  true;
            }
            return result;
        }

        /// <summary>
        /// Skilar Röð úr WinningCombination[][]
        /// </summary>
        /// <param name="i">i er númer raðar</param>
        /// <returns>
        /// Streng sem er 3 á lengd og inniheldur röð úr WinningCombination[][]
        /// </returns>
        public String[] getWinningCombinationRow(int i)
        {
            String[] output = new String[3];
            for (int j = 0; j < 3; j++)
            {
                output.SetValue(winningCombinations[i][j], j);
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
        public String[] getWinningCombinationColumn(int i)
        {
            i = i + 3;
            String[] output = new String[3];
            for (int j = 0; j < 3; j++)
            {
                output.SetValue(winningCombinations[i][j], j);
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
        public String[] getWinningCombinationDiagonal(int i)
        {
            i = i + 6;
            String[] output = new String[3];
            for (int j = 0; j < 3; j++)
            {
                output.SetValue(winningCombinations[i][j], j);
            }
            return output;
        }

        /// <summary>
        /// Teiknar borðið, fyllir út í reiti eftir gameBoard[] sem er fylki sem geymir hvað er búið og hvað er eftir.
        /// </summary>
        public void drawBoard()
        {
            int k = 0;
            for (int l = 0; l < 4; l++)
            {
                Console.Write("- ");
            }
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[k] + "|");
                    k++;
                }
                Console.Write("\n");
            }
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

        public virtual string[] AvailableMoves
        {
            get { return gameBoard.Distinct().ToArray(); } //TODO: VIRKAR EKKI ÞARF AÐ PARSEA ÚT BARA INTEGERS
        }

        /// <summary>
        /// Method til að athuga hvort kominn sé sigurvegari. Keyrir í gegnum winningCombinations[][] og athugar allar mögulegar útfærslur
        /// </summary>
        /// <param name="s">
        /// 's' er annað hvort 'X' eða 'O'.
        /// </param>

        public bool checkWinner()
        {
            String[] values = new String[3];
            for (int i = 0; i < 9 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    values[j] = winningCombinations[i][j];
                }
                if ((gameBoard[(Convert.ToInt32(values[0])) - 1] == gameBoard[(Convert.ToInt32(values[1])) - 1]) && (gameBoard[(Convert.ToInt32(values[1])) - 1] == gameBoard[(Convert.ToInt32(values[2])) - 1]))
                {
                    winner = true;
                    return winner;
                }
            }

            return false;

        }

		

        
        

			
        //Fall sem skrifar út winner
        
        //Switch með öllum mögulegum vinninsmöguleikum
         /// <summary>
        ///  Skilar True ef einhver röð gefur SUM 15
        ///  annars false.
        /// </summary>
        /*
        public bool isWinner()
        {
            bool winnerfound = false;

            //for testing
            StringBuilder st = new StringBuilder();

            for(int i=0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    //for testing
                    st.Append(moves[i,j]);
                    st.Append(",");
                    if (moves[i, j] == 15)
                    { 
                        winnerfound = true;                   
                    }
                }
            }

            //for testing
            Console.WriteLine(st);

            return winnerfound;
        }
        
        /// <summary>
        /// Setur öll gildi í moves breytunni í 0.
        /// </summary>
        public void resetMoves()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    moves[i,j] = 0;
                }
            }
        }

        /// <summary>
        ///  Reiknar út samtalgildi úr innra 3x3 fylkinu.
        ///  Ysti dálkurinn og neðsta röðin geyma gildin.
        /// </summary>
        public void calculateArray()
        {
            moves[0, 3] = moves[0, 0] + moves[0, 1] + moves[0, 2];
            moves[1, 3] = moves[1, 0] + moves[1, 1] + moves[1, 2];
            moves[2, 3] = moves[2, 0] + moves[2, 1] + moves[2, 2];
            moves[3, 3] = moves[0, 0] + moves[1, 1] + moves[2, 2];
            moves[3, 2] = moves[0, 2] + moves[1, 2] + moves[2, 2];
            moves[3, 1] = moves[0, 1] + moves[1, 1] + moves[2, 1];
            moves[3, 0] = moves[0, 0] + moves[1, 0] + moves[2, 0];
        }

        /// <summary>
        /// Skilar false ef val notanda er ekki leyft
        /// eða reitur hefur þegar verið valinn. Annars True
        /// </summary>
        public bool parseInput(string s)
        {
            bool isok = false;
        
            if (s.Length == 2)
            {
                int row = 5;//this initial value is to high to be approved.
                int column = int.Parse(s[1].ToString()) - 1;
                s = s.ToUpper();

                switch (s[0])
                {
                    case 'A':
                        row = 0;
                        break;
                    case 'B':
                        row = 1;
                        break;
                    case 'C':
                        row = 2;
                        break;
                }

            if (row == 0 || row == 1 || row == 2)
            {
                if (column == 0 || column == 1 || column == 2)
                {
                    if (moves[row, column] == 0)
                        {
                            isok = true;
                            setMove(row, column);
                            Console.WriteLine("Value is: {0}{1}", row, column);
                        }
                        else
                        {
                            isok = false;
                        }
                    }
                }
            }

            return isok;
        }
    }
#endregion
        #region Getters/Setters
        /// <summary>
        /// Skilar gildi vals notanda.
        /// </summary>
        public int getBoardValue(int i, int j)
        {
            return boardValue[i,j];
        }

        /// <summary>
        /// Vistar val notanda og keyrir uppfærslu á moves-fylkið
        /// </summary>
        public void setMove(int a, int b)
        {
            moves[a, b] = boardValue[a, b];
            calculateArray();
        }*/
    }
}
